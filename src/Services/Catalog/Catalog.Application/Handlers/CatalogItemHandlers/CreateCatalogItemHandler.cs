namespace Catalog.Application.Handlers.CatalogItemHandlers;

public class CreateCatalogItemHandler(ICatalogItemRepository catalogItemRepository)
    : IRequestHandler<CreateCatalogItemCommand, CreateCatalogItemResult>
{
    public async Task<CreateCatalogItemResult> Handle(CreateCatalogItemCommand command,
        CancellationToken cancellationToken)
    {
        var catalogItem = command.Adapt<CatalogItem>();
        catalogItem.Id = Guid.NewGuid();
        await catalogItemRepository.CreateCatalogItemAsync(catalogItem);
        return new CreateCatalogItemResult(catalogItem.Id);
    }
}

// public class CreateCatalogItemHandler(
//     ICatalogItemRepository catalogItemRepository,
//     IBrandRepository brandRepository,
//     ICategoryRepository categoryRepository)
//     : IRequestHandler<CreateCatalogItemCommand, CreateCatalogItemResult>
// {
//     public async Task<CreateCatalogItemResult> Handle(CreateCatalogItemCommand command, 
//         CancellationToken cancellationToken)
//     {
//         // Проверяем Brand
//         var brandExists = command.Brand != null
//             && (await brandRepository.GetAllBrandsAsync())
//             .Any(b => b.Id == command?.Brand?.Id);

//         if (!brandExists)
//         {
//             throw new ArgumentException("Указанный бренд не существует");
//         }

//         // Проверяем Category
//         var categoryExists = command.Category != null
//             && (await categoryRepository.GetAllCategoriesAsync())
//             .Any(c => c.Id == command.Category.Id);

//         if (!categoryExists)
//         {
//             throw new ArgumentException("Указанная категория не существует");
//         }

//         var catalogItem = command.Adapt<CatalogItem>();
//         catalogItem.Id = Guid.NewGuid();
//         await catalogItemRepository.CreateCatalogItemAsync(catalogItem);
//         return new CreateCatalogItemResult(catalogItem.Id);
//     }
// }
