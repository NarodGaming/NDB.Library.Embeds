using Discord;
using Discord.Rest;
using Discord.WebSocket;

namespace NDB.Library.Embeds
{
    public static class Embeds
    {
        public static Embed EmbedBuilder(String content, String title = "", String picture = "", String footer = "", String thumbnail = "")
        {
            EmbedBuilder builder = new();
            String? startTitle = NDB_Main._config["botname"];
            if (startTitle != null) { builder.Title = NDB_Main._config["botname"]; } else { title = "NDB"; }
            if (title != "") { builder.Title += " | " + title; }
            if (picture != "") { builder.ImageUrl= picture; }
            if (thumbnail != "") { builder.ThumbnailUrl = thumbnail; }
            if (footer != "") { builder.Footer.Text = footer; }
            String? colourString = NDB_Main._config["embedcolour"];
            if (colourString == null) { builder.Color = new Color(0x607D8B); } else { builder.Color = new Color(Convert.ToUInt32(colourString, 16)); }
            builder.Description = content;
            return builder.Build();
        }

        public static Task<RestUserMessage> ReplyEmbedAsync(ISocketMessageChannel responseChannel, String content, String title = "", String picture = "", String footer = "", String thumbnail = "")
        {
            return responseChannel.SendMessageAsync("", false, EmbedBuilder(content, title, picture));
        }
    }
}