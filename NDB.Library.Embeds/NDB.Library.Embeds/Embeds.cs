using Discord;
using Discord.Rest;
using Discord.WebSocket;

namespace NDB.Library.Embeds
{
    public static class Embeds
    {
        public static Embed EmbedBuilder(String content, String title = "", String picture = "", String footer = "", String thumbnail = "") // main function
        {
            EmbedBuilder builder = new(); // creates the embed builder
            String? startTitle = NDB_Main._config["botname"]; // gets the bot name and stores it in startTitle
            if (startTitle != null) { builder.Title = NDB_Main._config["botname"]; } else { title = "NDB"; } // if the starttitle isn't blank, then set the actual title to the botname title given, otherwise set it to 'NDB'
            if (title != "") { builder.Title += " | " + title; } // if a title has been passed, add that to the second half of the title
            if (picture != "") { builder.ImageUrl= picture; } // if a picture has been passed, add that
            if (thumbnail != "") { builder.ThumbnailUrl = thumbnail; } // if a thumbnail has been passed, add that
            if (footer != "") { builder.Footer.Text = footer; } // if a footer has been passed, add that
            String? colourString = NDB_Main._config["embedcolour"]; // set the colour of the embed to the embed colour given
            if (colourString == null) { builder.Color = new Color(0x607D8B); } else { builder.Color = new Color(Convert.ToUInt32(colourString, 16)); } // if no colour was given, use a default blue-ish colour
            builder.Description = content; // set the main part of the embed to the passed through arg
            return builder.Build(); // return the built embed, used by the main functions (though can be called seperately if ever needed)
        }

        public static Task<RestUserMessage> ReplyEmbedAsync(ISocketMessageChannel responseChannel, String content, String title = "", String picture = "", String footer = "", String thumbnail = "")
        {
            return responseChannel.SendMessageAsync(embed:EmbedBuilder(content, title, picture, footer, thumbnail));
        }

        public static Task<RestUserMessage> ReplyEmbedAsync(ISocketMessageChannel responseChannel, String content, ComponentBuilder component, String title = "", String picture = "", String footer = "", String thumbnail = "")
        {
            return responseChannel.SendMessageAsync(embed:EmbedBuilder(content, title, picture, footer, thumbnail), components: component.Build());
        }
    }
}