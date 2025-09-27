## [<<](./readme.md) Техническое задание №8

### Реализация gRPC-сервиса для удаления промо-акций

### Цель
Реализовать полный цикл CQRS для удаления промо-акций через gRPC: создать команду, обработчик, модели и gRPC-эндпоинт с использованием Protocol Buffers.

### Требования к реализации

1. **Proto-контракт**
   - Добавить RPC-метод `DeletePromo` в сервис `PromoService`
   - Определить сообщения `DeletePromoRequest` и `DeletePromoResponse`
   - `DeletePromoRequest` должен содержать: `catalog_item_id`
   - `DeletePromoResponse` должен содержать: `success`, `description`

2. **Команда (Command)**
   - Создать класс команды `DeletePromoCommand`
   - Параметр команды — строка `CatalogItemId`
   - Команда должна возвращать `DeletePromoResponse`

3. **Обработчик (Handler)**
   - Реализовать обработчик `DeletePromoCommandHandler` для обработки команды удаления
   - Обработчик должен использовать репозиторий `IPromoRepository` для удаления данных
   - Обработчик должен быть асинхронным и возвращать `DeletePromoResponse`

4. **Репозиторий**
   - Добавить метод `DeleteByCatalogItemIdAsync(string catalogItemId)` в интерфейс `IPromoRepository`
   - Реализовать метод в `PromoRepository` с SQL-запросом для удаления записей по `CatalogItemId`
   - Метод должен возвращать `bool` (успех операции)

5. **gRPC-сервис**
   - Реализовать метод `DeletePromo` в `PromoGrpcService`
   - Метод должен принимать `DeletePromoRequest`, создавать команду и отправлять через MediatR
   - Возвращать `DeletePromoResponse` с результатом операции

#### Дополнительно
- Все методы должны быть реализованы асинхронно
- Использовать Raw String Literals для SQL-запросов
- Удаление должно происходить по бизнес-ключу (`CatalogItemId`), а не по первичному ключу
- Добавить проверку на `null` параметров в репозитории
- Соблюдать принципы CQRS и чистой архитектуры
- Использовать MediatR для разделения бизнес-логики и транспортного слоя
- Возвращать понятные сообщения об успехе/неудаче операции
