namespace ThankmasCalendar.Pages
{
    public partial class Index
    {
        public bool WindowVisible { get; set; }
        public string Window1Css = "";
        public string Window2Css = "";
        public string Window3Css = "";
        public string Window4Css = "";
        public string Window5Css = "";
        public string Window6Css = "";
        public string Window7Css = "";
        public string Window8Css = "";
        public string Window9Css = "";
        public string Window10Css = "";
        public async Task HandleClick(int number)
        {
            switch (number)
            {
                case 1:
                    Window1Css = "animate__wobble";
                    await OpenWindow();
                    break;
                case 2:
                    Window2Css = "animate__wobble";
                    await OpenWindow();
                    break;
                case 3:
                    Window3Css = "animate__wobble";
                    await OpenWindow();
                    break;
                case 4:
                    Window4Css = "animate__wobble";
                    await OpenWindow();
                    break;
                case 5:
                    Window5Css = "animate__wobble";
                    await OpenWindow();
                    break;
                case 6:
                    Window6Css = "animate__wobble";
                    await OpenWindow();
                    break;
                case 7:
                    Window7Css = "animate__wobble";
                    await OpenWindow();
                    break;
                case 8:
                    Window8Css = "animate__wobble";
                    await OpenWindow();
                    break;
                case 9:
                    Window9Css = "animate__wobble";
                    await OpenWindow();
                    break;
                case 10:
                    Window10Css = "animate__wobble";
                    await OpenWindow();
                    break;
            }
        }

        public async Task OpenWindow()
        {
            var animationDelay = 900;
            await Task.Delay(animationDelay);
            WindowVisible = true;
        }
    }
}
