// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Admin
{

    /// <summary>
    /// com.atproto.admin Endpoint Group.
    /// </summary>
    public static class AdminEndpoints
    {

       public const string DeleteAccount = "/xrpc/com.atproto.admin.deleteAccount";

       public const string DisableAccountInvites = "/xrpc/com.atproto.admin.disableAccountInvites";

       public const string DisableInviteCodes = "/xrpc/com.atproto.admin.disableInviteCodes";

       public const string EnableAccountInvites = "/xrpc/com.atproto.admin.enableAccountInvites";

       public const string GetAccountInfo = "/xrpc/com.atproto.admin.getAccountInfo";

       public const string GetAccountInfos = "/xrpc/com.atproto.admin.getAccountInfos";

       public const string GetInviteCodes = "/xrpc/com.atproto.admin.getInviteCodes";

       public const string GetSubjectStatus = "/xrpc/com.atproto.admin.getSubjectStatus";

       public const string SearchAccounts = "/xrpc/com.atproto.admin.searchAccounts";

       public const string SendEmail = "/xrpc/com.atproto.admin.sendEmail";

       public const string UpdateAccountEmail = "/xrpc/com.atproto.admin.updateAccountEmail";

       public const string UpdateAccountHandle = "/xrpc/com.atproto.admin.updateAccountHandle";

       public const string UpdateAccountPassword = "/xrpc/com.atproto.admin.updateAccountPassword";

       public const string UpdateSubjectStatus = "/xrpc/com.atproto.admin.updateSubjectStatus";


        /// <summary>
        /// Delete a user account as an administrator.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="did"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="Success?"/></returns>
        public static Task<Result<Success?>> DeleteAccountAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid did, CancellationToken cancellationToken = default)
        {
            var endpointUrl = DeleteAccount.ToString();
            var inputItem = new DeleteAccountInput();
            inputItem.Did = did;
            return atp.Client.Post<DeleteAccountInput, Success?>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminDeleteAccountInput!, atp.Options.SourceGenerationContext.Success!, atp.Options.JsonSerializerOptions, inputItem, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Disable an account from receiving new invite codes, but does not invalidate existing codes.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="account"></param>
        /// <param name="note"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="Success?"/></returns>
        public static Task<Result<Success?>> DisableAccountInvitesAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid account, string? note = default, CancellationToken cancellationToken = default)
        {
            var endpointUrl = DisableAccountInvites.ToString();
            var inputItem = new DisableAccountInvitesInput();
            inputItem.Account = account;
            inputItem.Note = note;
            return atp.Client.Post<DisableAccountInvitesInput, Success?>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminDisableAccountInvitesInput!, atp.Options.SourceGenerationContext.Success!, atp.Options.JsonSerializerOptions, inputItem, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Disable some set of codes and/or all codes associated with a set of users.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="codes"></param>
        /// <param name="accounts"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="Success?"/></returns>
        public static Task<Result<Success?>> DisableInviteCodesAsync (this FishyFlip.ATProtocol atp, List<string>? codes = default, List<string>? accounts = default, CancellationToken cancellationToken = default)
        {
            var endpointUrl = DisableInviteCodes.ToString();
            var inputItem = new DisableInviteCodesInput();
            inputItem.Codes = codes;
            inputItem.Accounts = accounts;
            return atp.Client.Post<DisableInviteCodesInput, Success?>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminDisableInviteCodesInput!, atp.Options.SourceGenerationContext.Success!, atp.Options.JsonSerializerOptions, inputItem, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Re-enable an account's ability to receive invite codes.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="account"></param>
        /// <param name="note"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="Success?"/></returns>
        public static Task<Result<Success?>> EnableAccountInvitesAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid account, string? note = default, CancellationToken cancellationToken = default)
        {
            var endpointUrl = EnableAccountInvites.ToString();
            var inputItem = new EnableAccountInvitesInput();
            inputItem.Account = account;
            inputItem.Note = note;
            return atp.Client.Post<EnableAccountInvitesInput, Success?>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminEnableAccountInvitesInput!, atp.Options.SourceGenerationContext.Success!, atp.Options.JsonSerializerOptions, inputItem, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Get details about an account.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="did"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Atproto.Admin.AccountView?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Admin.AccountView?>> GetAccountInfoAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid did, CancellationToken cancellationToken = default)
        {
            var endpointUrl = GetAccountInfo.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            queryStrings.Add("did=" + did);

            endpointUrl += string.Join("&", queryStrings);
            return atp.Client.Get<FishyFlip.Lexicon.Com.Atproto.Admin.AccountView>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminAccountView!, atp.Options.JsonSerializerOptions, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Get details about some accounts.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="dids"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Atproto.Admin.GetAccountInfosOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Admin.GetAccountInfosOutput?>> GetAccountInfosAsync (this FishyFlip.ATProtocol atp, List<FishyFlip.Models.ATDid> dids, CancellationToken cancellationToken = default)
        {
            var endpointUrl = GetAccountInfos.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            queryStrings.Add(string.Join("&", dids.Select(n => "dids=" + n)));

            endpointUrl += string.Join("&", queryStrings);
            return atp.Client.Get<FishyFlip.Lexicon.Com.Atproto.Admin.GetAccountInfosOutput>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminGetAccountInfosOutput!, atp.Options.JsonSerializerOptions, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Get an admin view of invite codes.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Atproto.Admin.GetInviteCodesOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Admin.GetInviteCodesOutput?>> GetInviteCodesAsync (this FishyFlip.ATProtocol atp, string? sort = default, int? limit = 100, string? cursor = default, CancellationToken cancellationToken = default)
        {
            var endpointUrl = GetInviteCodes.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            if (sort != null)
            {
                queryStrings.Add("sort=" + sort);
            }

            if (limit != null)
            {
                queryStrings.Add("limit=" + limit);
            }

            if (cursor != null)
            {
                queryStrings.Add("cursor=" + cursor);
            }

            endpointUrl += string.Join("&", queryStrings);
            return atp.Client.Get<FishyFlip.Lexicon.Com.Atproto.Admin.GetInviteCodesOutput>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminGetInviteCodesOutput!, atp.Options.JsonSerializerOptions, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Get the service-specific admin status of a subject (account, record, or blob).
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="did"></param>
        /// <param name="uri"></param>
        /// <param name="blob"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Atproto.Admin.GetSubjectStatusOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Admin.GetSubjectStatusOutput?>> GetSubjectStatusAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid? did = default, FishyFlip.Models.ATUri? uri = default, string? blob = default, CancellationToken cancellationToken = default)
        {
            var endpointUrl = GetSubjectStatus.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            if (did != null)
            {
                queryStrings.Add("did=" + did);
            }

            if (uri != null)
            {
                queryStrings.Add("uri=" + uri);
            }

            if (blob != null)
            {
                queryStrings.Add("blob=" + blob);
            }

            endpointUrl += string.Join("&", queryStrings);
            return atp.Client.Get<FishyFlip.Lexicon.Com.Atproto.Admin.GetSubjectStatusOutput>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminGetSubjectStatusOutput!, atp.Options.JsonSerializerOptions, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Get list of accounts that matches your search query.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="email"></param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Atproto.Admin.SearchAccountsOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Admin.SearchAccountsOutput?>> SearchAccountsAsync (this FishyFlip.ATProtocol atp, string? email = default, string? cursor = default, int? limit = 50, CancellationToken cancellationToken = default)
        {
            var endpointUrl = SearchAccounts.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            if (email != null)
            {
                queryStrings.Add("email=" + email);
            }

            if (cursor != null)
            {
                queryStrings.Add("cursor=" + cursor);
            }

            if (limit != null)
            {
                queryStrings.Add("limit=" + limit);
            }

            endpointUrl += string.Join("&", queryStrings);
            return atp.Client.Get<FishyFlip.Lexicon.Com.Atproto.Admin.SearchAccountsOutput>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminSearchAccountsOutput!, atp.Options.JsonSerializerOptions, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Send email to a user's account email address.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="recipientDid"></param>
        /// <param name="content"></param>
        /// <param name="senderDid"></param>
        /// <param name="subject"></param>
        /// <param name="comment"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Atproto.Admin.SendEmailOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Admin.SendEmailOutput?>> SendEmailAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid recipientDid, string content, FishyFlip.Models.ATDid senderDid, string? subject = default, string? comment = default, CancellationToken cancellationToken = default)
        {
            var endpointUrl = SendEmail.ToString();
            var inputItem = new SendEmailInput();
            inputItem.RecipientDid = recipientDid;
            inputItem.Content = content;
            inputItem.SenderDid = senderDid;
            inputItem.Subject = subject;
            inputItem.Comment = comment;
            return atp.Client.Post<SendEmailInput, FishyFlip.Lexicon.Com.Atproto.Admin.SendEmailOutput?>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminSendEmailInput!, atp.Options.SourceGenerationContext.ComAtprotoAdminSendEmailOutput!, atp.Options.JsonSerializerOptions, inputItem, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Administrative action to update an account's email.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="account"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="Success?"/></returns>
        public static Task<Result<Success?>> UpdateAccountEmailAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier account, string email, CancellationToken cancellationToken = default)
        {
            var endpointUrl = UpdateAccountEmail.ToString();
            var inputItem = new UpdateAccountEmailInput();
            inputItem.Account = account;
            inputItem.Email = email;
            return atp.Client.Post<UpdateAccountEmailInput, Success?>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminUpdateAccountEmailInput!, atp.Options.SourceGenerationContext.Success!, atp.Options.JsonSerializerOptions, inputItem, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Administrative action to update an account's handle.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="did"></param>
        /// <param name="handle"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="Success?"/></returns>
        public static Task<Result<Success?>> UpdateAccountHandleAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid did, FishyFlip.Models.ATHandle handle, CancellationToken cancellationToken = default)
        {
            var endpointUrl = UpdateAccountHandle.ToString();
            var inputItem = new UpdateAccountHandleInput();
            inputItem.Did = did;
            inputItem.Handle = handle;
            return atp.Client.Post<UpdateAccountHandleInput, Success?>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminUpdateAccountHandleInput!, atp.Options.SourceGenerationContext.Success!, atp.Options.JsonSerializerOptions, inputItem, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Update the password for a user account as an administrator.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="did"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="Success?"/></returns>
        public static Task<Result<Success?>> UpdateAccountPasswordAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid did, string password, CancellationToken cancellationToken = default)
        {
            var endpointUrl = UpdateAccountPassword.ToString();
            var inputItem = new UpdateAccountPasswordInput();
            inputItem.Did = did;
            inputItem.Password = password;
            return atp.Client.Post<UpdateAccountPasswordInput, Success?>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminUpdateAccountPasswordInput!, atp.Options.SourceGenerationContext.Success!, atp.Options.JsonSerializerOptions, inputItem, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Update the service-specific admin status of a subject (account, record, or blob).
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="subject"></param>
        /// <param name="takedown"></param>
        /// <param name="deactivated"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Com.Atproto.Admin.UpdateSubjectStatusOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Admin.UpdateSubjectStatusOutput?>> UpdateSubjectStatusAsync (this FishyFlip.ATProtocol atp, ATObject subject, FishyFlip.Lexicon.Com.Atproto.Admin.StatusAttr takedown, FishyFlip.Lexicon.Com.Atproto.Admin.StatusAttr deactivated, CancellationToken cancellationToken = default)
        {
            var endpointUrl = UpdateSubjectStatus.ToString();
            var inputItem = new UpdateSubjectStatusInput();
            inputItem.Subject = subject;
            inputItem.Takedown = takedown;
            inputItem.Deactivated = deactivated;
            return atp.Client.Post<UpdateSubjectStatusInput, FishyFlip.Lexicon.Com.Atproto.Admin.UpdateSubjectStatusOutput?>(endpointUrl, atp.Options.SourceGenerationContext.ComAtprotoAdminUpdateSubjectStatusInput!, atp.Options.SourceGenerationContext.ComAtprotoAdminUpdateSubjectStatusOutput!, atp.Options.JsonSerializerOptions, inputItem, cancellationToken, atp.Options.Logger);
        }

    }
}

