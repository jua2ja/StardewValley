using MagicSkillCode.Framework.Schools;
using MagicSkillCode.Framework.Spells.Effects;
using StardewValley;
using MagicSkillCode.Core;
using SObject = StardewValley.Object;

namespace MagicSkillCode.Framework.Spells
{
    public class MeteorSpell : Spell
    {
        /*********
        ** Public methods
        *********/
        public MeteorSpell()
            : base(SchoolId.Eldritch, "meteor") { }

        public override int GetManaCost(Farmer player, int level)
        {
            return 0;
        }

        public override bool CanCast(Farmer player, int level)
        {
            return base.CanCast(player, level) && player.Items.ContainsId(SObject.iridium.ToString(), 1);
        }

        public override int GetMaxCastingLevel()
        {
            return 1;
        }

        public override IActiveEffect OnCast(Farmer player, int level, int targetX, int targetY)
        {
            player.Items.ReduceId(SObject.iridium.ToString(), 1);
            return new Meteor(player, targetX, targetY);
        }
    }
}
