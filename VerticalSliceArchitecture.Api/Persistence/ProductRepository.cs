using Shared.Repositories;
using VerticalSliceArchitecture.Api.Features.Products;
using VerticalSliceArchitecture.Api.Features.Products.Interfaces;

namespace VerticalSliceArchitecture.Api.Persistence;

public class ProductRepository(AppDbContext context) : BaseRepository<AppDbContext,Product,int>(context),IProductRepository;
