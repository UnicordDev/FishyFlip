// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Server
{

    /// <summary>
    /// com.atproto.server Endpoint Class.
    /// </summary>
    public sealed class ATProtoServer
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ATProtoServer"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ATProtoServer(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// Activates a currently deactivated account. Used to finalize account migration after the account's repo is imported and identity is setup.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> ActivateAccountAsync (CancellationToken cancellationToken = default)
        {
            return atp.ActivateAccountAsync(cancellationToken);
        }


        /// <summary>
        /// Returns the status of an account, especially as pertaining to import or recovery. Can be called many times over the course of an account migration. Requires auth and can only be called pertaining to oneself.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CheckAccountStatusOutput?>> CheckAccountStatusAsync (CancellationToken cancellationToken = default)
        {
            return atp.CheckAccountStatusAsync(cancellationToken);
        }


        /// <summary>
        /// Confirm an email using a token from com.atproto.server.requestEmailConfirmation.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.AccountNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.ExpiredTokenError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.InvalidTokenError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.InvalidEmailError"/>  <br/>
        /// </summary>
        /// <param name="email"></param>
        /// <param name="token"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> ConfirmEmailAsync (string email, string token, CancellationToken cancellationToken = default)
        {
            return atp.ConfirmEmailAsync(email, token, cancellationToken);
        }


        /// <summary>
        /// Create an account. Implemented by PDS.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.InvalidHandleError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.InvalidPasswordError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.InvalidInviteCodeError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.HandleNotAvailableError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.UnsupportedDomainError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.UnresolvableDidError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.IncompatibleDidDocError"/>  <br/>
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="email"></param>
        /// <param name="did"></param>
        /// <param name="inviteCode"></param>
        /// <param name="verificationCode"></param>
        /// <param name="verificationPhone"></param>
        /// <param name="password"></param>
        /// <param name="recoveryKey"></param>
        /// <param name="plcOp"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CreateAccountOutput?>> CreateAccountAsync (FishyFlip.Models.ATHandle handle, string? email = default, FishyFlip.Models.ATDid? did = default, string? inviteCode = default, string? verificationCode = default, string? verificationPhone = default, string? password = default, string? recoveryKey = default, ATObject? plcOp = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateAccountAsync(handle, email, did, inviteCode, verificationCode, verificationPhone, password, recoveryKey, plcOp, cancellationToken);
        }


        /// <summary>
        /// Create an App Password.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.AccountTakedownError"/>  <br/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="privileged"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.AppPassword?>> CreateAppPasswordAsync (string name, bool? privileged = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateAppPasswordAsync(name, privileged, cancellationToken);
        }


        /// <summary>
        /// Create an invite code.
        /// </summary>
        /// <param name="useCount"></param>
        /// <param name="forAccount"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodeOutput?>> CreateInviteCodeAsync (int useCount, FishyFlip.Models.ATDid? forAccount = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateInviteCodeAsync(useCount, forAccount, cancellationToken);
        }


        /// <summary>
        /// Create invite codes.
        /// </summary>
        /// <param name="codeCount"></param>
        /// <param name="useCount"></param>
        /// <param name="forAccounts"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesOutput?>> CreateInviteCodesAsync (int codeCount, int useCount, List<FishyFlip.Models.ATDid>? forAccounts = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateInviteCodesAsync(codeCount, useCount, forAccounts, cancellationToken);
        }


        /// <summary>
        /// Create an authentication session.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.AccountTakedownError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.AuthFactorTokenRequiredError"/>  <br/>
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="password"></param>
        /// <param name="authFactorToken"></param>
        /// <param name="allowTakendown"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.CreateSessionOutput?>> CreateSessionAsync (string identifier, string password, string? authFactorToken = default, bool? allowTakendown = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateSessionAsync(identifier, password, authFactorToken, allowTakendown, cancellationToken);
        }


        /// <summary>
        /// Deactivates a currently active account. Stops serving of repo, and future writes to repo until reactivated. Used to finalize account migration with the old host after the account has been activated on the new host.
        /// </summary>
        /// <param name="deleteAfter"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> DeactivateAccountAsync (DateTime? deleteAfter = default, CancellationToken cancellationToken = default)
        {
            return atp.DeactivateAccountAsync(deleteAfter, cancellationToken);
        }


        /// <summary>
        /// Delete an actor's account with a token and password. Can only be called after requesting a deletion token. Requires auth.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.ExpiredTokenError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.InvalidTokenError"/>  <br/>
        /// </summary>
        /// <param name="did"></param>
        /// <param name="password"></param>
        /// <param name="token"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> DeleteAccountAsync (FishyFlip.Models.ATDid did, string password, string token, CancellationToken cancellationToken = default)
        {
            return atp.DeleteAccountAsync(did, password, token, cancellationToken);
        }


        /// <summary>
        /// Delete the current session. Requires auth.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> DeleteSessionAsync (CancellationToken cancellationToken = default)
        {
            return atp.DeleteSessionAsync(cancellationToken);
        }


        /// <summary>
        /// Describes the server's account creation requirements and capabilities. Implemented by PDS.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.DescribeServerOutput?>> DescribeServerAsync (CancellationToken cancellationToken = default)
        {
            return atp.DescribeServerAsync(cancellationToken);
        }


        /// <summary>
        /// Get all invite codes for the current account. Requires auth.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.DuplicateCreateError"/>  <br/>
        /// </summary>
        /// <param name="includeUsed"></param>
        /// <param name="createAvailable"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.GetAccountInviteCodesOutput?>> GetAccountInviteCodesAsync (bool? includeUsed = default, bool? createAvailable = default, CancellationToken cancellationToken = default)
        {
            return atp.GetAccountInviteCodesAsync(includeUsed, createAvailable, cancellationToken);
        }


        /// <summary>
        /// Get a signed token on behalf of the requesting DID for the requested service.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.BadExpirationError"/> Indicates that the requested expiration date is not a valid. May be in the past or may be reliant on the requested scopes. <br/>
        /// </summary>
        /// <param name="aud"></param>
        /// <param name="exp"></param>
        /// <param name="lxm"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.GetServiceAuthOutput?>> GetServiceAuthAsync (FishyFlip.Models.ATDid aud, int? exp = 0, string? lxm = default, CancellationToken cancellationToken = default)
        {
            return atp.GetServiceAuthAsync(aud, exp, lxm, cancellationToken);
        }


        /// <summary>
        /// Get information about the current auth session. Requires auth.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.GetSessionOutput?>> GetSessionAsync (CancellationToken cancellationToken = default)
        {
            return atp.GetSessionAsync(cancellationToken);
        }


        /// <summary>
        /// List all App Passwords.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.AccountTakedownError"/>  <br/>
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.ListAppPasswordsOutput?>> ListAppPasswordsAsync (CancellationToken cancellationToken = default)
        {
            return atp.ListAppPasswordsAsync(cancellationToken);
        }


        /// <summary>
        /// Refresh an authentication session. Requires auth using the 'refreshJwt' (not the 'accessJwt').
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.AccountTakedownError"/>  <br/>
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.RefreshSessionOutput?>> RefreshSessionAsync (CancellationToken cancellationToken = default)
        {
            return atp.RefreshSessionAsync(cancellationToken);
        }


        /// <summary>
        /// Initiate a user account deletion via email.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> RequestAccountDeleteAsync (CancellationToken cancellationToken = default)
        {
            return atp.RequestAccountDeleteAsync(cancellationToken);
        }


        /// <summary>
        /// Request an email with a code to confirm ownership of email.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> RequestEmailConfirmationAsync (CancellationToken cancellationToken = default)
        {
            return atp.RequestEmailConfirmationAsync(cancellationToken);
        }


        /// <summary>
        /// Request a token in order to update email.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.RequestEmailUpdateOutput?>> RequestEmailUpdateAsync (CancellationToken cancellationToken = default)
        {
            return atp.RequestEmailUpdateAsync(cancellationToken);
        }


        /// <summary>
        /// Initiate a user account password reset via email.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> RequestPasswordResetAsync (string email, CancellationToken cancellationToken = default)
        {
            return atp.RequestPasswordResetAsync(email, cancellationToken);
        }


        /// <summary>
        /// Reserve a repo signing key, for use with account creation. Necessary so that a DID PLC update operation can be constructed during an account migraiton. Public and does not require auth; implemented by PDS. NOTE: this endpoint may change when full account migration is implemented.
        /// </summary>
        /// <param name="did"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Server.ReserveSigningKeyOutput?>> ReserveSigningKeyAsync (FishyFlip.Models.ATDid? did = default, CancellationToken cancellationToken = default)
        {
            return atp.ReserveSigningKeyAsync(did, cancellationToken);
        }


        /// <summary>
        /// Reset a user account password using a token.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.ExpiredTokenError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.InvalidTokenError"/>  <br/>
        /// </summary>
        /// <param name="token"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> ResetPasswordAsync (string token, string password, CancellationToken cancellationToken = default)
        {
            return atp.ResetPasswordAsync(token, password, cancellationToken);
        }


        /// <summary>
        /// Revoke an App Password by name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> RevokeAppPasswordAsync (string name, CancellationToken cancellationToken = default)
        {
            return atp.RevokeAppPasswordAsync(name, cancellationToken);
        }


        /// <summary>
        /// Update an account's email.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.ExpiredTokenError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.InvalidTokenError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.TokenRequiredError"/>  <br/>
        /// </summary>
        /// <param name="email"></param>
        /// <param name="emailAuthFactor"></param>
        /// <param name="token"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> UpdateEmailAsync (string email, bool? emailAuthFactor = default, string? token = default, CancellationToken cancellationToken = default)
        {
            return atp.UpdateEmailAsync(email, emailAuthFactor, token, cancellationToken);
        }

    }
}

