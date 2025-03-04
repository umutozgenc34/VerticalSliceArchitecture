using Shared.Repositories;
using VerticalSliceArchitecture.Api.Features.Categories;
using VerticalSliceArchitecture.Api.Features.Categories.Interfaces;

namespace VerticalSliceArchitecture.Api.Persistence;

public class CategoryRepository(AppDbContext context) : BaseRepository<AppDbContext,Category,int>(context),ICategoryRepository;


