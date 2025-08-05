# Специальное предложение

[Получите доступ к полному курсу со скидкой](https://stepik.org/a/249828/pay?promo=c8777ac1d5fe0d3d&utm_source=readme&utm_medium=github&utm_campaign=sep2025&utm_content=a)


## C#: Руководство по созданию микросервисов на .NET
Добро пожаловать в комплексный курс по разработке микросервисов на .NET и C# с использованием передовых технологий и подходов современного бэкенд-разработчика. 

## О курсе

Это публичный репозиторий курса, в рамках которое является детальным руководством по созданию микросервисов с чистой архитектурой и современными интеграциями. Вы научитесь:

- Использовать CQRS и MediatR для четкого разделения команд и запросов,
- Настраивать и использовать базы данных PostgreSQL и MySQL с Marten, Dapper ORM и Entity Framework,
- Версионировать и документировать API с помощью Swagger,
- Реализовывать высокопроизводительный синхронный gRPC и асинхронный обмен сообщениями через RabbitMQ и MassTransit,
- Внедрять Redis для кэширования и увеличения производительности,
- Автоматизировать CI/CD процессы с GitHub Actions, создавать шаблоны проектов,
- Строить централизованную систему логирования на базе Serilog и ELK Stack,
- Настраивать сбор и визуализацию метрик через Prometheus и Grafana,
- Проводить нагрузочное тестирование сервисов с k6,
- Управлять контейнеризированной инфраструктурой с помощью Docker и Portainer,
- Применять лучшие паттерны проектирования и практики аудита для повышения надежности приложений.

Курс идеально подходит для backend-разработчиков и архитекторов, желающих освоить современные практики построения микросервисной архитектуры от начала до production-уровня.

## Структура курса

Модульно построенный учебный план охватывает все этапы разработки — от создания шаблона микросервиса, через построение каталогов и корзин, интеграцию промоакций, оформление заказов, до месседжинга, логирования, мониторинга и управления инфраструктурой.

- Модуль 1-2: Шаблон микросервиса, инфраструктура и DevOps автоматизация
- Модуль 3-5: Каталог микросервиса и продвинутые CQRS-паттерны
- Модуль 6-7: Корзина и Redis-кэширование
- Модуль 8-9: Микросервис промоакций с gRPC и MySQL
- Модуль 10-11: Интеграция микросервисов, взаимодействие и промо
- Модуль 12-13: Оформление заказов с EF Core и CQRS
- Модуль 14: Месседжинг, RabbitMQ и MassTransit
- Модуль 15: Логирование, мониторинг с ELK, Prometheus, Grafana и управление Docker-инфраструктурой
- _Модуль 16 и дальше: возможно появятся новые модули_

## Основные технологии и библиотеки

### Таблица NuGet-библиотек
| Logo | Наименование библиотеки | Версия | Описание |
| :-- | :-- | :-- | :-- |
| <img src="https://github.com/dotnet/aspnet-api-versioning/blob/main/logo.svg" width="32" height="32"/> | Asp.Versioning.Mvc | 8.1.0 | API версияция для ASP.NET MVC |
| <img src="https://github.com/dotnet/aspnet-api-versioning/blob/main/logo.svg" width="32" height="32" /> | Asp.Versioning.Mvc.ApiExplorer | 8.1.0 | API версияция с поддержкой ApiExplorer |
| <img src="https://api.nuget.org/v3-flatcontainer/carter/9.0.0/icon" width="32" height="32" /> | Carter | 9.0.0 | Легкий фреймворк для построения HTTP API |
| <img src="https://api.nuget.org/v3-flatcontainer/dapper/2.1.66/icon" width="32" height="32" /> | Dapper | 2.1.66 | Микро ORM для доступа к базе данных |
| <img src="https://api.nuget.org/v3-flatcontainer/fluentvalidation/12.0.0/icon" width="32" height="32" /> | FluentValidation | 12.0.0 | Валидация моделей с Fluent синтаксисом |
| <img src="https://api.nuget.org/v3-flatcontainer/fluentvalidation.dependencyinjectionextensions/12.0.0/icon" width="32" height="32" /> | FluentValidation.DependencyInjectionExtensions | 12.0.0 | Внедрение FluentValidation в DI контейнер |
| <img src="https://nuget.org/Content/gallery/img/default-package-icon-256x256.png" width="32" height="32" /> | Google.Protobuf | 3.31.1 | Сериализация и десериализация Protocol Buffers |
| <img src="https://api.nuget.org/v3-flatcontainer/grpc.aspnetcore/2.71.0/icon" width="32" height="32" /> | Grpc.AspNetCore | 2.71.0 | gRPC сервер для ASP.NET Core |
| <img src="https://api.nuget.org/v3-flatcontainer/grpc.aspnetcore.server.clientfactory/2.71.0/icon" width="32" height="32" /> | Grpc.AspNetCore.Server.ClientFactory | 2.71.0 | gRPC серверный клиент фабрика для ASP.NET Core |
| <img src="https://api.nuget.org/v3-flatcontainer/grpc.aspnetcore.server.reflection/2.71.0/icon" width="32" height="32" /> | Grpc.AspNetCore.Server.Reflection | 2.71.0 | gRPC сервер Reflection для ASP.NET Core |
| <img src="https://api.nuget.org/v3-flatcontainer/grpc.tools/2.72.0/icon" width="32" height="32" /> | Grpc.Tools | 2.72.0 | Инструменты разработки gRPC |
| <img src="https://cloud.githubusercontent.com/assets/5763993/26522718/d16f3e42-4330-11e7-9b78-f8c7402624e7.png" width="32" height="32" /> | Mapster | 7.4.0 | Объектно-реляционное маппирование и маппинг |
| <img src="https://cloud.githubusercontent.com/assets/5763993/26522718/d16f3e42-4330-11e7-9b78-f8c7402624e7.png" width="32" height="32" /> | Mapster.DependencyInjection | 1.0.1 | Mapster с поддержкой DI |
| <img src="https://api.nuget.org/v3-flatcontainer/marten/8.3.1/icon" width="32" height="32" /> | Marten | 8.3.1 | Транзакционная DocumentDB и Event Store для PostgreSQL |
| <img src="https://avatars2.githubusercontent.com/u/317796?s=200&v=4" width="32" height="32" /> | MassTransit.RabbitMQ | 8.5.1 | RabbitMQ интеграция для MassTransit |
| <img src="https://api.nuget.org/v3-flatcontainer/mediatr/13.0.0/icon" width="32" height="32" /> | MediatR | 13.0.0 | Реализация паттерна Mediator для .NET |
| <img src="https://avatars.githubusercontent.com/u/9141961?s=48&v=4" width="32" height="32" /> | Microsoft.CodeAnalysis.CSharp.Workspaces | 4.11.0 | Рабочие пространства для C# с анализатором Roslyn |
| <img src="https://avatars.githubusercontent.com/u/9141961?s=48&v=4" width="32" height="32" /> | Microsoft.CodeAnalysis.Common | 4.11.0 | Общие библиотеки Roslyn для анализа кода |
| <img src="https://api.nuget.org/v3-flatcontainer/microsoft.entityframeworkcore/9.0.7/icon" width="32" height="32" /> | Microsoft.EntityFrameworkCore | 9.0.7 | EF Core основной пакет для работы с БД |
| <img src="https://api.nuget.org/v3-flatcontainer/microsoft.entityframeworkcore.design/9.0.7/icon" width="32" height="32" /> | Microsoft.EntityFrameworkCore.Design | 9.0.7 | Инструменты проектирования EF Core |
| <img src="https://api.nuget.org/v3-flatcontainer/microsoft.entityframeworkcore.tools/9.0.7/icon" width="32" height="32" /> | Microsoft.EntityFrameworkCore.Tools | 9.0.7 | Инструменты командной строки и миграций EF Core |
| <img src="https://api.nuget.org/v3-flatcontainer/microsoft.extensions.caching.stackexchangeredis/9.0.7/icon" width="32" height="32" /> | Microsoft.Extensions.Caching.StackExchangeRedis | 9.0.7 | Кэширование с использованием Redis |
| <img src="https://api.nuget.org/v3-flatcontainer/microsoft.extensions.configuration/9.0.7/icon" width="32" height="32" /> | Microsoft.Extensions.Configuration | 9.0.7 | Конфигурация приложения |
| <img src="https://api.nuget.org/v3-flatcontainer/microsoft.extensions.dependencyinjection.abstractions/9.0.7/icon" width="32" height="32" /> | Microsoft.Extensions.DependencyInjection.Abstractions | 9.0.7 | Интерфейсы для DI |
| <img src="https://api.nuget.org/v3-flatcontainer/microsoft.featuremanagement.aspnetcore/4.2.1/icon" width="32" height="32" /> | Microsoft.FeatureManagement.AspNetCore | 4.2.1 | Фича-менеджмент для ASP.NET Core |
| <img src="https://api.nuget.org/v3-flatcontainer/mysqlconnector/2.4.0/icon" width="32" height="32" /> | MySqlConnector | 2.4.0 | Асинхронный MySQL коннектор |
| <img src="https://api.nuget.org/v3-flatcontainer/npgsql.entityframeworkcore.postgresql/9.0.4/icon" width="32" height="32" /> | Npgsql.EntityFrameworkCore.PostgreSQL | 9.0.4 | PostgreSQL EF Core провайдер |
| <img src="https://nuget.org/Content/gallery/img/default-package-icon-256x256.png" width="32" height="32" /> | Scrutor | 6.1.0 | Расширение для регистрации сервисов с фильтрами |
| <img src="https://api.nuget.org/v3-flatcontainer/serilog/4.3.0/icon" width="32" height="32" /> | Serilog | 4.3.0 | Логирование с Serilog |
| <img src="https://avatars.githubusercontent.com/u/5691010?s=48&v=4" width="32" height="32" /> | Serilog.AspNetCore | 9.0.0 | Интеграция Serilog в ASP.NET Core |
| <img src="https://nuget.org/Content/gallery/img/default-package-icon-256x256.png" width="32" height="32" /> | Serilog.Enrichers.CorrelationId | 3.0.1 | Enricher для CorrelationId в логах |
| <img src="https://api.nuget.org/v3-flatcontainer/serilog.enrichers.environment/3.0.1/icon" width="32" height="32" /> | Serilog.Enrichers.Environment | 3.0.1 | Enricher для окружения в логах |
| <img src="https://nuget.org/Content/gallery/img/default-package-icon-256x256.png" width="32" height="32" /> | Serilog.Extensions.Hosting | 9.0.0 | Регистрация Serilog как хоста приложения |
| <img src="https://api.nuget.org/v3-flatcontainer/serilog.settings.configuration/9.0.0/icon" width="32" height="32" /> | Serilog.Settings.Configuration | 9.0.0 | Настройки Serilog через конфигурацию |
| <img src="https://nuget.org/Content/gallery/img/default-package-icon-256x256.png" width="32" height="32" /> | Serilog.Sinks.Console | 6.0.0 | Логирование в консоль |
| <img src="https://api.nuget.org/v3-flatcontainer/serilog.sinks.elasticsearch/10.0.0/icon" width="32" height="32" /> | Serilog.Sinks.Elasticsearch | 10.0.0 | Логирование в Elasticsearch |
| <img src="https://api.nuget.org/v3-flatcontainer/serilog.sinks.file/7.0.0/icon" width="32" height="32" /> | Serilog.Sinks.File | 7.0.0 | Логирование в файл |
| <img src="https://nuget.org/Content/gallery/img/default-package-icon-256x256.png" width="32" height="32" /> | Swashbuckle.AspNetCore | 9.0.3 | Swagger для ASP.NET Core |
| <img src="https://nuget.org/Content/gallery/img/default-package-icon-256x256.png" width="32" height="32" /> | Swashbuckle.AspNetCore.Annotations | 9.0.3 | Swagger Annotations для документации API |
| <img src="https://api.nuget.org/v3-flatcontainer/prometheus-net.aspnetcore/8.2.1/icon" width="32" height="32" /> | prometheus-net.AspNetCore | 8.2.1 | Prometheus метрики для ASP.NET Core |


### Таблица с docker образами
| Logo | Наименование образа | Краткое описание назначения |
| :-- | :-- | :-- |
| <img src="https://cdn.simpleicons.org/postgresql" width="32" height="32" alt="PostgreSQL" /> | [postgres](https://hub.docker.com/_/postgres) | Официальный образ PostgreSQL, используется как СУБД для Rest-сервисов |
| <img src="https://cdn.simpleicons.org/redis" width="32" height="32" alt="Redis" /> | [redis](https://hub.docker.com/_/redis) | In-memory хранилище данных и кэша |
| <img src="https://cdn.simpleicons.org/mysql" width="32" height="32" alt="MySQL" /> | [mysql:8.0](https://hub.docker.com/_/mysql) | Официальный MySQL образ, используется как СУБД для gRPC-сервиса |
| <img src="https://cdn.simpleicons.org/rabbitmq" width="32" height="32" alt="RabbitMQ" /> | [rabbitmq:3-management](https://hub.docker.com/_/rabbitmq) | Очередь сообщений RabbitMQ с UI менеджером, обеспечивает асинхронное взаимодействие сервисов |
| <img src="https://cdn.simpleicons.org/elasticsearch" width="32" height="32" alt="Elasticsearch" /> | [elasticsearch:9.0.3](https://hub.docker.com/_/elasticsearch) | Поисковый и аналитический движок, обеспечивает хранение и поиск для сервисов |
| <img src="https://cdn.simpleicons.org/kibana" width="32" height="32" alt="Kibana" /> | [kibana:9.0.3](https://hub.docker.com/_/kibana) | Визуализация логов и данных из Elasticsearch, мониторинг состояния |
| <img src="https://cdn.simpleicons.org/k6" width="32" height="32" alt="k6" /> | [grafana/k6](https://hub.docker.com/r/grafana/k6) | Инструмент для нагрузочного тестирования API сервисов |
| <img src="https://cdn.simpleicons.org/prometheus" width="32" height="32" alt="Prometheus" /> | [prom/prometheus](https://hub.docker.com/r/prom/prometheus) | Система мониторинга и сбора метрик приложений и сервисов |
| <img src="https://cdn.simpleicons.org/grafana" width="32" height="32" alt="Grafana" /> | [grafana/grafana](https://hub.docker.com/r/grafana/grafana) | Веб-интерфейс для визуализации и анализа метрик, интегрируется с Prometheus |
| <img src="https://cdn.simpleicons.org/portainer" width="32" height="32" alt="Portainer" /> | [portainer/portainer-ce](https://hub.docker.com/r/portainer/portainer-ce) | Веб-интерфейс для управления Docker-контейнерами и кластерами |


## Что вы получите

- Полную архитектуру с реализацией шаблонного микросервиса,
- Готовые шаблоны для CQRS, MediatR, gRPC, RabbitMQ,
- Надежные практики логирования и мониторинга,
- Отработанные шаблоны интеграций и продвинутой обработки ошибок,
- Производительность и устойчивость сервисов на практике,
- Уникальный опыт создания рабочей инфраструктуры для микросервисов.

## Инструменты мониторинга, логирования и документации

Последние разделы курса посвящены не только автоматизации и инфраструктуре, но и построению системы наблюдаемости микросервисов с помощью лучших инструментов — ELK Stack (стек для агрегации и визуализации логов), Prometheus и Grafana (для метрик и дашбордов), Portainer (интерфейс для управления Docker-инфраструктурой), а также интерактивной Swagger-документации.

Вы увидите, как:

- В одной системе собирать и анализировать структурированные логи в Kibana через ELK;
- Обеспечивать мониторинг промышленных метрик с Prometheus и строить наглядные графики в Grafana;
- Гибко управлять всеми контейнерами через Portainer;
- Предоставлять удобную, версионированную, интерактивную документацию API через Swagger UI.

## Живые скриншоты по реальным интерфейсам и дашбордам


### Swagger UI микросервис каталога

<img src="./assenst/catalog-api.png" width="800" /> 

### Swagger UI микросервис корзины

<img src="./assenst/basket-api.png" width="800" /> 

### Микросервис скидок, доступ только с postman

<img src="./assenst/promotion-grpc.png" width="800" /> 

### Swagger UI микросервис заказов

<img src="./assenst/checkout-api.png" width="800" />


### Мониторинг логов и некоторые метрики

<img src="./assenst/elk.png" width="800" />

### Веб-интерфейс prometheus

<img src="./assenst/prometheus.png" width="800" />


### Дашборд с мониторингом микросервиса каталога

<img src="./assenst/grafana.png" width="800" />

### Логи k6 на чтение [скрипт можно посмотреть тут](./k6/catalog-api-load-test.js)

<img src="./assenst/k6-1.png" width="800" />

### Логи k6 на запись [скрипт можно посмотреть тут](./k6/catalog-api-create-items-test.js)

<img src="./assenst/k6-2.png" width="800" />

### Работоспособность приложения поддерживают 17 контейнеров

<img src="./assenst/portainer-1.png" width="800" />   

---

<img src="./assenst/portainer-2.png" width="800" />   

---

<img src="./assenst/docker-desktop.png" width="800" />   

### Ссылки для локального `localhost`

| Сервис         | URL для доступа                                     |
|----------------|-----------------------------------------------------|
| catalog-api    | http://localhost:7301/swagger/                      |
| basket-api     | http://localhost:7302/swagger/                      |
| promotion-api  | grpc://localhost:7313                               |
| checkout-api   | http://localhost:7304/swagger/                      |
| portainer      | https://localhost:9443                              |
| grafana        | http://localhost:3000                               |
| prometheus     | http://localhost:9090                               |
| kibana         | http://localhost:5601                               |
| rabbitmq UI    | http://localhost:15672                              |
