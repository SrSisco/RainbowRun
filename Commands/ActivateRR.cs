using System;
using CommandSystem;
using Exiled.Permissions.Extensions;

namespace RainbowRun.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class ActivateRR : ICommand
    {
        public string Command => "activateRR";
        public string[] Aliases { get; } = {"activeRR","ARR","RRR","runRR"};
        public string Description => "Run the RR event";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (sender.CheckPermission("RR.start") || sender.CheckPermission(PlayerPermissions.PlayersManagement))
            {
                if (RainbowRun.Instance.Config.IsActive)
                {
                    response = "RainbowRun is already active";
                    return false;
                }
                else
                {
                    RainbowRun.Instance.Config.IsActive = true;
                    response = "RainbowRun is now active!";
                    return true;
                }

            }
            else
            {
                response = "You don't have enough permissions to run this command";
                return false;
            }
        }
    }
}