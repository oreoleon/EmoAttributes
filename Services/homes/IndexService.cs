using EmoAttributes.Models;  // EmoAttributes.Models 名前空間をインポート
using EmoAttributes.Repositories; 

namespace EmoAttributes.Services
{
    public class HomeService
    {
        private readonly IEmoAttributesRepository _repository;

        public HomeService(IEmoAttributesRepository repository)
        {
            _repository = repository;
        }

        // Indexアクションで表示するデータを取得する
        public IEnumerable<EmoAttribute> GetEmoAttributes()
        {
            return _repository.GetAll();
        }
    }
}
