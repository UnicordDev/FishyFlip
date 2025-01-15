// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Whtwnd.Blog
{

    /// <summary>
    /// com.whtwnd.blog Endpoint Group.
    /// </summary>
    public static class BlogEndpoints
    {

       public const string GetAuthorPosts = "/xrpc/com.whtwnd.blog.getAuthorPosts";

       public const string GetEntryMetadataByName = "/xrpc/com.whtwnd.blog.getEntryMetadataByName";

       public const string GetMentionsByEntry = "/xrpc/com.whtwnd.blog.getMentionsByEntry";

       public const string NotifyOfNewEntry = "/xrpc/com.whtwnd.blog.notifyOfNewEntry";


        /// <summary>
        /// Get blog posts associated to designated author.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="author"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Whtwnd.Blog.GetAuthorPostsOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Whtwnd.Blog.GetAuthorPostsOutput?>> GetAuthorPostsAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid author, CancellationToken cancellationToken = default)
        {
            var endpointUrl = GetAuthorPosts.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            queryStrings.Add("author=" + author);

            var headers = new Dictionary<string, string>();
            headers.Add(Constants.AtProtoAcceptLabelers, atp.Options.LabelDefinitionsHeader);
            endpointUrl += string.Join("&", queryStrings);
            return atp.Get<FishyFlip.Lexicon.Com.Whtwnd.Blog.GetAuthorPostsOutput>(endpointUrl, atp.Options.SourceGenerationContext.ComWhtwndBlogGetAuthorPostsOutput!, cancellationToken, headers);
        }


        /// <summary>
        /// Get AT URI by blog author and entry name. If there are multiple blog entries associated with the name, return the latest one.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.NotFoundError"/> If the associated name isn't registered in the author's repo, this error is returned <br/>
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="author"></param>
        /// <param name="entryTitle"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Whtwnd.Blog.GetEntryMetadataByNameOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Whtwnd.Blog.GetEntryMetadataByNameOutput?>> GetEntryMetadataByNameAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier author, string entryTitle, CancellationToken cancellationToken = default)
        {
            var endpointUrl = GetEntryMetadataByName.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            queryStrings.Add("author=" + author);

            queryStrings.Add("entryTitle=" + entryTitle);

            var headers = new Dictionary<string, string>();
            headers.Add(Constants.AtProtoAcceptLabelers, atp.Options.LabelDefinitionsHeader);
            endpointUrl += string.Join("&", queryStrings);
            return atp.Get<FishyFlip.Lexicon.Com.Whtwnd.Blog.GetEntryMetadataByNameOutput>(endpointUrl, atp.Options.SourceGenerationContext.ComWhtwndBlogGetEntryMetadataByNameOutput!, cancellationToken, headers);
        }


        /// <summary>
        /// Get comments associated to designated post.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="postUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Whtwnd.Blog.GetMentionsByEntryOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Whtwnd.Blog.GetMentionsByEntryOutput?>> GetMentionsByEntryAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri postUri, CancellationToken cancellationToken = default)
        {
            var endpointUrl = GetMentionsByEntry.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            queryStrings.Add("postUri=" + postUri);

            var headers = new Dictionary<string, string>();
            headers.Add(Constants.AtProtoAcceptLabelers, atp.Options.LabelDefinitionsHeader);
            endpointUrl += string.Join("&", queryStrings);
            return atp.Get<FishyFlip.Lexicon.Com.Whtwnd.Blog.GetMentionsByEntryOutput>(endpointUrl, atp.Options.SourceGenerationContext.ComWhtwndBlogGetMentionsByEntryOutput!, cancellationToken, headers);
        }


        /// <summary>
        /// Notify AppView of existence of new entry and request indexing
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="entryUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Whtwnd.Blog.NotifyOfNewEntryOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Whtwnd.Blog.NotifyOfNewEntryOutput?>> NotifyOfNewEntryAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri entryUri, CancellationToken cancellationToken = default)
        {
            var endpointUrl = NotifyOfNewEntry.ToString();
            var headers = new Dictionary<string, string>();
            var inputItem = new NotifyOfNewEntryInput();
            inputItem.EntryUri = entryUri;
            return atp.Post<NotifyOfNewEntryInput, FishyFlip.Lexicon.Com.Whtwnd.Blog.NotifyOfNewEntryOutput?>(endpointUrl, atp.Options.SourceGenerationContext.ComWhtwndBlogNotifyOfNewEntryInput!, atp.Options.SourceGenerationContext.ComWhtwndBlogNotifyOfNewEntryOutput!, inputItem, cancellationToken, headers);
        }

    }
}

