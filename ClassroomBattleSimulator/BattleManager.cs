using ClassroomBattleSimulator;

namespace ClassroomBattleSimulator
{
    public class BattleManager
    {
        public Character player1;
        public Character player2;
        private int currentPlayerIndex = 0; // 0 = player1, 1 = player2

        public bool IsGameOver => player1.Health <= 0 || player2.Health <= 0;

        public Character CurrentPlayer => currentPlayerIndex == 0 ? player1 : player2;
        public Character Opponent => currentPlayerIndex == 0 ? player2 : player1;

        public BattleManager(Character p1, Character p2)
        {
            player1 = p1;
            player2 = p2;
        }

        // Returns a string describing the turn's result
        // Executes skill, updates defense turns, switches turn
        public string ExecuteTurn(int skillIndex)
        {
            var skill = CurrentPlayer.Skills[skillIndex];
            string result;

            if (skill.IsHealing)
            {
                CurrentPlayer.Heal(skill.Power);
                result = $"{CurrentPlayer.Name} uses {skill.Name} and heals {skill.Power} HP.";
            }
            else if (skill.IsDefensive)
            {
                CurrentPlayer.ActivateDefense();
                result = $"{CurrentPlayer.Name} uses {skill.Name} and raises defense for 3 turns.";
            }
            else
            {
                Opponent.ReceiveDamage(skill.Power);
                result = $"{CurrentPlayer.Name} uses {skill.Name} and deals {skill.Power} damage to {Opponent.Name}.";
            }

            // Decrement defense duration
            player1.DecrementDefense();
            player2.DecrementDefense();

            // Switch turn if game not over
            if (!IsGameOver)
                currentPlayerIndex = 1 - currentPlayerIndex;

            return result;
        }


        public Character GetWinner()
        {
            if (player1.Health <= 0 && player2.Health <= 0)
                return null; // tie
            if (player1.Health <= 0)
                return player2;
            if (player2.Health <= 0)
                return player1;
            return null; // no winner yet
        }
    }
}