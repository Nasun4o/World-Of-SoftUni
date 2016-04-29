namespace WorldOfSoftuniRPG.Models.Items.AttackItems
{
    using WorldOfSoftuniRPG.Enumerations;
    using WorldOfSoftuniRPG.Models.Items.UniqueItem;

    public class Belt : DefenceAttack
    { 
        private const int CommonAttack = 75;
        private const int UncommonAttack = 100;
        private const int RareAttack = 135;
        private const int MagicAttack = 160;
        private const int LegendaryAttack = 185;

        private const int CommonDefence = 25;
        private const int UncommonDefence = 50;
        private const int RareDefence = 80;
        private const int MagicDefence = 90;
        private const int LegendaryDefence = 115;

        private const ItemType DefaultType = ItemType.Common;

        public Belt(ItemType itemType = DefaultType)
            : base(itemType)
        {
        }

        public override int Defence
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return CommonDefence;
                    case ItemType.Uncommon: return UncommonDefence;
                    case ItemType.Rare: return RareDefence;
                    case ItemType.Magic: return MagicDefence;
                    case ItemType.Legendary: return LegendaryDefence;
                    default: return CommonDefence;
                }
            }
        }

        public override int Attack
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return CommonAttack;
                    case ItemType.Uncommon: return UncommonAttack;
                    case ItemType.Rare: return RareAttack;
                    case ItemType.Magic: return MagicAttack;
                    case ItemType.Legendary: return LegendaryAttack;
                    default: return CommonAttack;
                }
            }
        }
    }
}