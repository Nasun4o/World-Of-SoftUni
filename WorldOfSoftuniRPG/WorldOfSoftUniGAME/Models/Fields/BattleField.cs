﻿namespace WorldOfSoftuniRPG.Models.Fields
{
    using System.Collections.Generic;
    using System.Text;
    using WorldOfSoftuniRPG.Enumerations;
    using WorldOfSoftuniRPG.Models.Players;

    public class BattleField : Field
    {
        private static Dictionary<EnemyType, int> attackedEnemies = new Dictionary<EnemyType, int>()
        {
            { EnemyType.Ghoul, 0 },
            { EnemyType.Hydra, 0 },
            { EnemyType.Supremus, 0 },
            { EnemyType.Rotface, 0 },
            { EnemyType.Lichking, 0 },
            { EnemyType.Deathwing, 0 }
        };

        private static IList<Enemy> enemies;
        private static Enemy targetEnemy;

        public static Dictionary<EnemyType, int> AttackedEnemies
        {
            get
            {
                return attackedEnemies;
            }
        }

        public static IList<Enemy> Enemies
        {
            get
            {
                return enemies;
            }

            set
            {
                enemies = value;
            }
        }

        public static Enemy TargetEnemy
        {
            get
            {
                return targetEnemy;
            }

            set
            {
                targetEnemy = value;
            }
        }

        public static string PrintBattleField()
        {
            StringBuilder printBattleField = new StringBuilder();

            string printHero = PrintHero();
            printBattleField.Append(printHero);
            printBattleField.AppendLine();
            printBattleField.AppendLine("-------------------------------------------------------------------------------");
            printBattleField.AppendLine("For attack emeny enter command \"attack\" + \"enemy name\" ");
            printBattleField.AppendLine("-------------------------------------------------------------------------------");

            if (Enemies != null && Enemies.Count > 0)
            {
                const int MaxCellSize = 13;
                printBattleField.Append("Type".PadRight(MaxCellSize, ' '));
                printBattleField.Append("Gold".PadRight(MaxCellSize, ' '));
                printBattleField.Append("Attack".PadRight(MaxCellSize, ' '));
                printBattleField.Append("Defence".PadRight(MaxCellSize, ' '));
                printBattleField.Append("Health".PadRight(MaxCellSize, ' '));
                printBattleField.AppendLine("Left".PadRight(MaxCellSize));
                foreach (var enemy in Enemies)
                {
                    printBattleField.AppendLine(enemy.ToString());
                }
            }
            else
            {
                printBattleField.AppendLine("No enimies.");
            }

            return printBattleField.ToString();
        }
    }
}