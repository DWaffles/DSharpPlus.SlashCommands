using System.Collections.Generic;
using System.Threading.Tasks;
using DSharpPlus.Entities;

namespace DSharpPlus.SlashCommands.TestBot
{
	public class Autocomplete : IAutocompleteProvider
	{
		public async Task<IEnumerable<DiscordAutoCompleteChoice>> Provider(AutocompleteContext ctx) =>
			new DiscordAutoCompleteChoice[]
			{
				new("Current option name: " + ctx.FocusedOption.Name, ctx.FocusedOption.Name),
				new("Let there be autocomplete!", "lettherebeac"),
				new("What you wrote:", "__"),
				new(ctx.FocusedOption.Value.ToString(), ctx.FocusedOption.Value),
			};
	}
}