// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{

    /// <summary>
    /// chat.bsky.convo Endpoint Class.
    /// </summary>
    public sealed class ChatBskyConvo
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBskyConvo"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ChatBskyConvo(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.deleteMessageForSelf
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.DeletedMessageView?>> DeleteMessageForSelfAsync (string convoId, string messageId, CancellationToken cancellationToken = default)
        {
            return atp.DeleteMessageForSelfAsync(convoId, messageId, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.getConvo
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.GetConvoOutput?>> GetConvoAsync (string convoId, CancellationToken cancellationToken = default)
        {
            return atp.GetConvoAsync(convoId, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.getConvoForMembers
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.GetConvoForMembersOutput?>> GetConvoForMembersAsync (List<FishyFlip.Models.ATDid?> members, CancellationToken cancellationToken = default)
        {
            return atp.GetConvoForMembersAsync(members, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.getLog
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.GetLogOutput?>> GetLogAsync (string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.GetLogAsync(cursor, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.getMessages
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.GetMessagesOutput?>> GetMessagesAsync (string convoId, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.GetMessagesAsync(convoId, limit, cursor, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.leaveConvo
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.LeaveConvoOutput?>> LeaveConvoAsync (string convoId, CancellationToken cancellationToken = default)
        {
            return atp.LeaveConvoAsync(convoId, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.listConvos
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.ListConvosOutput?>> ListConvosAsync (int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.ListConvosAsync(limit, cursor, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.muteConvo
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.MuteConvoOutput?>> MuteConvoAsync (string convoId, CancellationToken cancellationToken = default)
        {
            return atp.MuteConvoAsync(convoId, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.sendMessage
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.MessageView?>> SendMessageAsync (string convoId, FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput message, CancellationToken cancellationToken = default)
        {
            return atp.SendMessageAsync(convoId, message, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.sendMessageBatch
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.SendMessageBatchOutput?>> SendMessageBatchAsync (List<FishyFlip.Lexicon.Chat.Bsky.Convo.BatchItem?> items, CancellationToken cancellationToken = default)
        {
            return atp.SendMessageBatchAsync(items, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.unmuteConvo
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.UnmuteConvoOutput?>> UnmuteConvoAsync (string convoId, CancellationToken cancellationToken = default)
        {
            return atp.UnmuteConvoAsync(convoId, cancellationToken);
        }


        /// <summary>
        /// Generated endpoint for chat.bsky.convo.updateRead
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Chat.Bsky.Convo.UpdateReadOutput?>> UpdateReadAsync (string convoId, string? messageId = default, CancellationToken cancellationToken = default)
        {
            return atp.UpdateReadAsync(convoId, messageId, cancellationToken);
        }

    }
}

