using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace SimpleUtil
{
    public class ModEntry : Mod
    {
        private float maxStam;
        private float currentStam;
        private float stamDiff;

        private int maxHeal;
        private int currentHeal;
        private int healDiff;

        private int moneyUsed;
        public override void Entry(IModHelper helper)
        {

            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
            helper.Events.GameLoop.DayStarted += this.OnDayStarted;

        }

        private void OnDayStarted(object sender, DayStartedEventArgs e)
        {
            if (!Context.IsWorldReady)
            {
                return;
            }
            newDayMessages();
        }

        public void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (!Context.IsWorldReady) 
            {
                return;
            }

            if (e.Button == SButton.L) // Lets the player fill stamina based on the amount of money they have (1 money = 1 stamina point) up to 250 at a time
            {
                fillStamina();
            }

            if (e.Button == SButton.J) // Lets the player heal based on the amount of money they have (1 money = 1 health point) up to 250 at a time
            {
                fillHealth();
            }
        }



        /*--------------------------------------------------------------------------------------------------------------------------------------------------------*/

        private void newDayMessages() 
        {
            
        }

        private void fillStamina() // Lets the player fill stamina based on the amount of money they have (1 money = 1 stamina point) up to 250 at a time
        {
            maxStam = Game1.player.maxStamina;
            currentStam = Game1.player.stamina;
            stamDiff = maxStam - currentStam;
            if (!(Game1.player.Money >= 250 || Game1.player.Money >= stamDiff))
            {
                moneyUsed = Game1.player.Money;
                Game1.player.stamina += Game1.player.Money;
                Game1.player.Money = 0;
                Game1.addHUDMessage(new HUDMessage("Used " + moneyUsed + "G to fill " + moneyUsed + " stamina points.", 4));
                return;
            }
            if (stamDiff < 250)
            {
                moneyUsed = Convert.ToInt32(stamDiff);
                Game1.player.stamina += stamDiff;
                Game1.player.Money -= Convert.ToInt32(stamDiff);
                Game1.addHUDMessage(new HUDMessage("Used " + moneyUsed + "G to fill " + moneyUsed + " stamina points.", 4));
                return;
            }
            Game1.player.stamina += 250;
            Game1.player.Money -= 250;
            Game1.addHUDMessage(new HUDMessage("Used 250G to fill 250 stamina points.", 4));
        }

        private void fillHealth() // Lets the player heal based on the amount of money they have (1 money = 1 health point) up to 250 at a time
        {
            maxHeal = Game1.player.maxHealth;
            currentHeal = Game1.player.health;
            healDiff = maxHeal - currentHeal;
            if (!(Game1.player.Money >= 250 || Game1.player.Money >= healDiff))
            {
                moneyUsed = Game1.player.Money;
                Game1.player.health += Game1.player.Money;
                Game1.player.Money = 0;
                Game1.addHUDMessage(new HUDMessage("Used " + moneyUsed + "G to fill " + moneyUsed + " stamina points.", 4));
                return;
            }
            if (healDiff < 250)
            {
                moneyUsed = Convert.ToInt32(healDiff);
                Game1.player.health += healDiff;
                Game1.player.Money -= healDiff;
                Game1.addHUDMessage(new HUDMessage("Used " + moneyUsed + "G to fill " + moneyUsed + " health points.", 5));
                return;
            }
            Game1.player.health += 250;
            Game1.player.Money -= 250;
            Game1.addHUDMessage(new HUDMessage("Used 250G to fill 250 health points.", 5));
        }

    }
}
