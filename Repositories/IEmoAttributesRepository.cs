using EmoAttributes.Models;  // EmoAttributes.Models 名前空間をインポート

namespace EmoAttributes.Repositories
{
    public interface IEmoAttributesRepository
    {
        // 全てのEmoAttributeを取得
        IEnumerable<EmoAttribute> GetAll();

        // IDでEmoAttributeを取得
        EmoAttribute GetById(int id);

        // EmoAttributeを追加
        void Add(EmoAttribute emoAttribute);

        // EmoAttributeを更新
        void Update(EmoAttribute emoAttribute);

        // EmoAttributeを削除
        void Delete(int id);
    }
}
