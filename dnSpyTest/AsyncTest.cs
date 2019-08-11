using System;
using System.Threading.Tasks;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using static MahApps.Metro.Controls.Dialogs.MessageDialogStyle;
namespace dnSpyTest
{
    public class AsyncTest: MetroWindow
    {
        public async void NewTest()
        {
            var result = await
                this.ShowMessageAsync("Exporting multiple decks!", $"You are about to export {0} decks. Are you sure?",
                    AffirmativeAndNegative);
            if (result != MessageDialogResult.Affirmative)
                return;
        }
    }
}
