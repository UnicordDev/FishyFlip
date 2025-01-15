// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Whtwnd.Blog
{

    /// <summary>
    /// com.whtwnd.blog Endpoint Class.
    /// </summary>
    public sealed class ComWhtwndBlog
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComWhtwndBlog"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ComWhtwndBlog(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// Get blog posts associated to designated author.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Whtwnd.Blog.GetAuthorPostsOutput?>> GetAuthorPostsAsync (FishyFlip.Models.ATDid author, CancellationToken cancellationToken = default)
        {
            return atp.GetAuthorPostsAsync(author, cancellationToken);
        }


        /// <summary>
        /// Get AT URI by blog author and entry name. If there are multiple blog entries associated with the name, return the latest one.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.NotFoundError"/> If the associated name isn't registered in the author's repo, this error is returned <br/>
        /// </summary>
        /// <param name="author"></param>
        /// <param name="entryTitle"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Whtwnd.Blog.GetEntryMetadataByNameOutput?>> GetEntryMetadataByNameAsync (FishyFlip.Models.ATIdentifier author, string entryTitle, CancellationToken cancellationToken = default)
        {
            return atp.GetEntryMetadataByNameAsync(author, entryTitle, cancellationToken);
        }


        /// <summary>
        /// Get comments associated to designated post.
        /// </summary>
        /// <param name="postUri"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Whtwnd.Blog.GetMentionsByEntryOutput?>> GetMentionsByEntryAsync (FishyFlip.Models.ATUri postUri, CancellationToken cancellationToken = default)
        {
            return atp.GetMentionsByEntryAsync(postUri, cancellationToken);
        }


        /// <summary>
        /// Notify AppView of existence of new entry and request indexing
        /// </summary>
        /// <param name="entryUri"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Whtwnd.Blog.NotifyOfNewEntryOutput?>> NotifyOfNewEntryAsync (FishyFlip.Models.ATUri entryUri, CancellationToken cancellationToken = default)
        {
            return atp.NotifyOfNewEntryAsync(entryUri, cancellationToken);
        }

    }
}

