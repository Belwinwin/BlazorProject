using BlazorProject.Data;

namespace BlazorProject.Repository.iRepository
{
    public interface iCategoryRepository
    {
        public Category Create(Category obj);
        public Category Update(Category obj);
        public bool Delete(int id);
        public Category Get(int id);
        public IEnumerable<Category> GetAll();

    }
}
