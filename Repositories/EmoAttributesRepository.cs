using EmoAttributes.Models;  // EmoAttributes.Models 名前空間をインポート

namespace EmoAttributes.Repositories
{
    public class EmoAttributesRepository : IEmoAttributesRepository
    {
        private static List<EmoAttribute> _emoAttributes = new List<EmoAttribute>
        {
            new EmoAttribute { Id = 1, Name = "Happy" },
            new EmoAttribute { Id = 2, Name = "Sad" },
            new EmoAttribute { Id = 3, Name = "Excited" }
        };

        // 全てのEmoAttributeを取得
        public IEnumerable<EmoAttribute> GetAll()
        {
            return _emoAttributes;
        }

        // IDでEmoAttributeを取得
        public EmoAttribute GetById(int id)
        {
            return _emoAttributes.FirstOrDefault(e => e.Id == id);
        }

        // EmoAttributeを追加
        public void Add(EmoAttribute emoAttribute)
        {
            _emoAttributes.Add(emoAttribute);
        }

        // EmoAttributeを更新
        public void Update(EmoAttribute emoAttribute)
        {
            var existing = _emoAttributes.FirstOrDefault(e => e.Id == emoAttribute.Id);
            if (existing != null)
            {
                existing.Name = emoAttribute.Name;
            }
        }

        // EmoAttributeを削除
        public void Delete(int id)
        {
            var emoAttribute = _emoAttributes.FirstOrDefault(e => e.Id == id);
            if (emoAttribute != null)
            {
                _emoAttributes.Remove(emoAttribute);
            }
        }
    }
}
