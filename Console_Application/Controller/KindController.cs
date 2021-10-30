using System;
using System.Text.RegularExpressions;
using Business.Services;
using Entities.Models;
using Utilies.Helper;

namespace Console_Application.Controller
{
    public class KindController
    {
        public KindServices kindService { get; }
        public KindController()
        {
            kindService = new KindServices();
        }

        public void Create()
        {
        EnterType: Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Please, Enter kind of clothes: ");
            string name = Console.ReadLine();
            name.Trim();
            bool IsAlpha = Regex.IsMatch(name, "^[a-zA-Z]+$");
            if (name.Length > 15)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "The Name of the Kind cannot exceed 15 characters");
                goto EnterType;
            }
            if (IsAlpha != true)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please,name of kind cannot be empty or numeric!");
                goto EnterType;
            }
            else
            {
                Kind kind = new Kind { kindName = name };
                if (kindService.Create(kind) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, $"{kind.kindName} is created");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkMagenta, $"{kind.kindName} category already exists");
                    return;
                }


            }

        }
    }
}
