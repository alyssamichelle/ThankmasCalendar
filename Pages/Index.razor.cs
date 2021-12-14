using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace ThankmasCalendar.Pages
{
	public partial class Index
	{

		[Inject]
		public ILocalStorageService LocalStorage { get; set; }

		public HashSet<byte> OpenWindows { get; set; } = new HashSet<byte>();

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
					await OpenWindow(number);
					break;
				case 2:
					Window2Css = "animate__wobble";
					await OpenWindow(number);
					break;
				case 3:
					Window3Css = "animate__wobble";
					await OpenWindow(number);
					break;
				case 4:
					Window4Css = "animate__wobble";
					await OpenWindow(number);
					break;
				case 5:
					Window5Css = "animate__wobble";
					await OpenWindow(number);
					break;
				case 6:
					Window6Css = "animate__wobble";
					await OpenWindow(number);
					break;
				case 7:
					Window7Css = "animate__wobble";
					await OpenWindow(number);
					break;
				case 8:
					Window8Css = "animate__wobble";
					await OpenWindow(number);
					break;
				case 9:
					Window9Css = "animate__wobble";
					await OpenWindow(number);
					break;
				case 10:
					Window10Css = "animate__wobble";
					await OpenWindow(number);
					break;
			}
		}

		protected override async Task OnInitializedAsync()
		{

			OpenWindows = await LocalStorage.GetItemAsync<HashSet<byte>>("OpenWindows") ?? new();

			await  base.OnInitializedAsync();

		}

		// NOTE: This should start on the 14th so that day 1 is the 15th
		private static readonly DateOnly BaseDate = new DateOnly(2021, 12, 14);
		private bool IsError = false;

		public MarkupString WindowContent = new MarkupString("");
		public string WindowTitle = String.Empty;
		public string WindowHyperlinkText { get; set; } = string.Empty;
		public string WindowHyperlinkUrl { get; set; } = string.Empty;

		public async Task OpenWindow(int windowNumber)
		{

			Console.WriteLine($"Opening window {windowNumber}");
			IsError = false;

			var animationDelay = 900;
			await Task.Delay(animationDelay);
			WindowVisible = true;
			WindowTitle = $"You've opened window #{windowNumber}";

			if (BaseDate.AddDays(windowNumber) > DateOnly.FromDateTime(DateTime.Now))
			{
				IsError = true;
				WindowTitle = "You're going on the NAUGHTY LIST!";
				return;
			}
			else
			{

				var thisDay = ThankmasCalendar.WindowContent.Days.First(d => d.Id == windowNumber);
				WindowContent = new MarkupString(thisDay.WindowText);
				WindowHyperlinkText = thisDay.HyperlinkText;
				WindowHyperlinkUrl = thisDay.Hyperlink;

				OpenWindows.Add((byte)windowNumber);
				await LocalStorage.SetItemAsync("OpenWindows", OpenWindows);

			}

		}
	}
}
