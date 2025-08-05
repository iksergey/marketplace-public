import { textSummary } from 'https://jslib.k6.io/k6-summary/0.0.1/index.js';
import { check, sleep } from 'k6';
import http from 'k6/http';

export let options = {
    stages: [
        { duration: '30s', target: 3 },  // Плавный ramp-up до 3 пользователей
        { duration: '30s', target: 5 },  // Увеличение нагрузки до 5 пользователей
        { duration: '8m', target: 10 },  // Пиковая нагрузка 10 пользователей
        { duration: '1m', target: 0 },   // Плавное снижение до 0
    ],
    setupTimeout: '30s', // Время ожидания setup функции
    thresholds: {
        http_req_duration: ['p(95)<2000'], // 95% запросов должны выполняться менее чем за 2 секунды
        http_req_failed: ['rate<0.10'],    // Менее 10% запросов должны завершаться ошибкой
    },
};

const BASE_URL = __ENV.BASE_URL_CATALOG || 'http://catalog_api:8080';

export function setup() {
    console.log('🔧 Проверка доступности Catalog API...');

    // Проверяем доступность API перед началом нагрузочного тестирования
    let healthCheck = http.get(`${BASE_URL}/api/v1/brands`);
    if (healthCheck.status !== 200) {
        throw new Error(`Catalog API недоступен: ${healthCheck.status} - ${healthCheck.status_text}`);
    }

    console.log('✅ Catalog API доступен');
    console.log('🚀 Начинаем нагрузочное тестирование Catalog API');
    return { baseUrl: BASE_URL };
}

export default function (data) {
    // Тестируем различные endpoints Catalog API
    const endpoints = [
        '/api/v1/Brands',
        '/api/v1/Categories',
        '/api/v1/CatalogItem',
        '/api/v2/CatalogItem?PageIndex=3&Sort=price_desc&PageSize=2'
    ];

    // Случайно выбираем endpoint для имитации реального поведения пользователей
    const endpoint = endpoints[
        Math.floor(Math.random() * endpoints.length)
    ];
    const response = http.get(`${data.baseUrl}${endpoint}`);

    // Проверяем различные аспекты ответа
    const checkResults = check(response, {
        'статус успешный (2xx)': (r) => r.status >= 200 && r.status < 300,
        'время ответа приемлемое (<2000ms)': (r) => r.timings.duration < 2000,
        'получен валидный JSON': (r) => {
            try {
                JSON.parse(r.body);
                return true;
            } catch (e) {
                console.error(`❌ Невалидный JSON в ответе: ${e.message}`);
                return false;
            }
        },
        'размер ответа больше 0': (r) => r.body && r.body.length > 0,
        'заголовок Content-Type корректный': (r) =>
            r.headers['Content-Type'] && r.headers['Content-Type'].includes('application/json'),
    });

    // Детальное логирование ошибок для анализа
    if (response.status >= 400) {
        console.error(`❌ Ошибка на ${endpoint}: ${response.status} - ${response.status_text}`);
        console.error(`   Тело ответа: ${response.body.substring(0, 200)}...`);
    }

    // Логируем медленные запросы
    if (response.timings.duration > 1000) {
        console.warn(`🐌 Медленный запрос ${endpoint}: ${response.timings.duration}ms`);
    }

    // Имитируем реальное поведение пользователей с паузами между запросами
    sleep(Math.random() * 3 + 1); // Случайная пауза от 1 до 4 секунд
}

export function teardown(data) {
    console.log('📊 Нагрузочное тестирование Catalog API завершено');
    console.log(`🔗 Тестировался URL: ${data.baseUrl}`);
}

// Функция для сохранения детального отчета о тестировании
export function handleSummary(data) {
    return {
        'catalog-load-test-results.json': JSON.stringify(data, null, 2),
        'stdout': textSummary(data, { indent: ' ', enableColors: true }),
    };
}
