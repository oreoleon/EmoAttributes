namespace EmoAttributes.Models
{
    public class EmoAttribute
    {
        public int Id { get; set; }        // EmoAttributeのID
        public string Name { get; set; }    // EmoAttributeの名前（例: 感情名、特徴名など）
        public string Description { get; set; } // 説明（任意）
        
        // 必要に応じて他のプロパティも追加可能
    }
}
