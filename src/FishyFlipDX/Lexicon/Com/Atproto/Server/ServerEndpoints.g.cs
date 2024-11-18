// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Server
{

    /// <summary>
    /// com.atproto.server Endpoint Group.
    /// </summary>
    public static class ServerEndpoints
    {

       public const string ActivateAccount = "/xrpc/com.atproto.server.activateAccount";

       public const string CheckAccountStatus = "/xrpc/com.atproto.server.checkAccountStatus";

       public const string ConfirmEmail = "/xrpc/com.atproto.server.confirmEmail";

       public const string CreateAccount = "/xrpc/com.atproto.server.createAccount";

       public const string CreateAppPassword = "/xrpc/com.atproto.server.createAppPassword";

       public const string CreateInviteCode = "/xrpc/com.atproto.server.createInviteCode";

       public const string CreateInviteCodes = "/xrpc/com.atproto.server.createInviteCodes";

       public const string CreateSession = "/xrpc/com.atproto.server.createSession";

       public const string DeactivateAccount = "/xrpc/com.atproto.server.deactivateAccount";

       public const string DeleteAccount = "/xrpc/com.atproto.server.deleteAccount";

       public const string DeleteSession = "/xrpc/com.atproto.server.deleteSession";

       public const string DescribeServer = "/xrpc/com.atproto.server.describeServer";

       public const string GetAccountInviteCodes = "/xrpc/com.atproto.server.getAccountInviteCodes";

       public const string GetServiceAuth = "/xrpc/com.atproto.server.getServiceAuth";

       public const string GetSession = "/xrpc/com.atproto.server.getSession";

       public const string ListAppPasswords = "/xrpc/com.atproto.server.listAppPasswords";

       public const string RefreshSession = "/xrpc/com.atproto.server.refreshSession";

       public const string RequestAccountDelete = "/xrpc/com.atproto.server.requestAccountDelete";

       public const string RequestEmailConfirmation = "/xrpc/com.atproto.server.requestEmailConfirmation";

       public const string RequestEmailUpdate = "/xrpc/com.atproto.server.requestEmailUpdate";

       public const string RequestPasswordReset = "/xrpc/com.atproto.server.requestPasswordReset";

       public const string ReserveSigningKey = "/xrpc/com.atproto.server.reserveSigningKey";

       public const string ResetPassword = "/xrpc/com.atproto.server.resetPassword";

       public const string RevokeAppPassword = "/xrpc/com.atproto.server.revokeAppPassword";

       public const string UpdateEmail = "/xrpc/com.atproto.server.updateEmail";


        /// <summary>
        /// Activates a currently deactivated account. Used to finalize account migration after the account's repo is imported and identity is setup.
        /// </summary>
        public static Task<Result<Success>> ActivateAccountAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns the status of an account, especially as pertaining to import or recovery. Can be called many times over the course of an account migration. Requires auth and can only be called pertaining to oneself.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CheckAccountStatusOutput>> CheckAccountStatusAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Confirm an email using a token from com.atproto.server.requestEmailConfirmation.
        /// </summary>
        public static Task<Result<Success>> ConfirmEmailAsync (this FishyFlip.ATProtocol atp, string email, string token, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create an account. Implemented by PDS.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CreateAccountOutput>> CreateAccountAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATHandle handle, string? email = default, FishyFlip.Models.ATDid? did = default, string? inviteCode = default, string? verificationCode = default, string? verificationPhone = default, string? password = default, string? recoveryKey = default, ATObject? plcOp = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create an App Password.
        /// </summary>
        public static Task<Result<Success>> CreateAppPasswordAsync (this FishyFlip.ATProtocol atp, string name, bool? privileged = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create an invite code.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodeOutput>> CreateInviteCodeAsync (this FishyFlip.ATProtocol atp, int useCount, FishyFlip.Models.ATDid? forAccount = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create invite codes.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesOutput>> CreateInviteCodesAsync (this FishyFlip.ATProtocol atp, int codeCount, int useCount, List<FishyFlip.Models.ATDid>? forAccounts = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create an authentication session.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CreateSessionOutput>> CreateSessionAsync (this FishyFlip.ATProtocol atp, string identifier, string password, string? authFactorToken = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Deactivates a currently active account. Stops serving of repo, and future writes to repo until reactivated. Used to finalize account migration with the old host after the account has been activated on the new host.
        /// </summary>
        public static Task<Result<Success>> DeactivateAccountAsync (this FishyFlip.ATProtocol atp, DateTime? deleteAfter = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete an actor's account with a token and password. Can only be called after requesting a deletion token. Requires auth.
        /// </summary>
        public static Task<Result<Success>> DeleteAccountAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid did, string password, string token, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete the current session. Requires auth.
        /// </summary>
        public static Task<Result<Success>> DeleteSessionAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Describes the server's account creation requirements and capabilities. Implemented by PDS.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.DescribeServerOutput>> DescribeServerAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get all invite codes for the current account. Requires auth.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.GetAccountInviteCodesOutput>> GetAccountInviteCodesAsync (this FishyFlip.ATProtocol atp, bool? includeUsed = default, bool? createAvailable = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a signed token on behalf of the requesting DID for the requested service.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.GetServiceAuthOutput>> GetServiceAuthAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid aud, int? exp = 0, string? lxm = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get information about the current auth session. Requires auth.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.GetSessionOutput>> GetSessionAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// List all App Passwords.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.ListAppPasswordsOutput>> ListAppPasswordsAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Refresh an authentication session. Requires auth using the 'refreshJwt' (not the 'accessJwt').
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.RefreshSessionOutput>> RefreshSessionAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Initiate a user account deletion via email.
        /// </summary>
        public static Task<Result<Success>> RequestAccountDeleteAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Request an email with a code to confirm ownership of email.
        /// </summary>
        public static Task<Result<Success>> RequestEmailConfirmationAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Request a token in order to update email.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.RequestEmailUpdateOutput>> RequestEmailUpdateAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Initiate a user account password reset via email.
        /// </summary>
        public static Task<Result<Success>> RequestPasswordResetAsync (this FishyFlip.ATProtocol atp, string email, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Reserve a repo signing key, for use with account creation. Necessary so that a DID PLC update operation can be constructed during an account migraiton. Public and does not require auth; implemented by PDS. NOTE: this endpoint may change when full account migration is implemented.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.ReserveSigningKeyOutput>> ReserveSigningKeyAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid? did = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Reset a user account password using a token.
        /// </summary>
        public static Task<Result<Success>> ResetPasswordAsync (this FishyFlip.ATProtocol atp, string token, string password, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Revoke an App Password by name.
        /// </summary>
        public static Task<Result<Success>> RevokeAppPasswordAsync (this FishyFlip.ATProtocol atp, string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update an account's email.
        /// </summary>
        public static Task<Result<Success>> UpdateEmailAsync (this FishyFlip.ATProtocol atp, string email, bool? emailAuthFactor = default, string? token = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

    }
}

