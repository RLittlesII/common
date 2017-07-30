﻿// Copyright Matthias Koch 2017.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;
using JetBrains.Annotations;

namespace Nuke.Core.BuildServers
{
    /// <summary>
    /// Interface according to the <a href="http://devcenter.bitrise.io/faq/available-environment-variables/#exposed-by-bitriseio">official website</a>.
    /// </summary>
    [PublicAPI]
    [BuildServer]
    public class Bitrise
    {
        [CanBeNull]
        public static Bitrise Instance { get; } = EnvironmentInfo.Variable("BITRISE_BUILD_URL") != null ? new Bitrise() : null;

        private Bitrise ()
        {
        }

        public string BuildUrl => EnvironmentInfo.EnsureVariable("BITRISE_BUILD_URL");
        public int BuildNumber => EnvironmentInfo.EnsureVariable<int>("BITRISE_BUILD_NUMBER");
        public string AppTitle => EnvironmentInfo.EnsureVariable("BITRISE_APP_TITLE");
        public string AppUrl => EnvironmentInfo.EnsureVariable("BITRISE_APP_URL");
        public string AppSlug => EnvironmentInfo.EnsureVariable("BITRISE_APP_SLUG");
        public string BuildSlug => EnvironmentInfo.EnsureVariable("BITRISE_BUILD_SLUG");
        public DateTime BuildTriggerTimestamp => EnvironmentInfo.EnsureVariable<DateTime>("BITRISE_BUILD_TRIGGER_TIMESTAMP");
        public string RepositoryUrl => EnvironmentInfo.EnsureVariable("GIT_REPOSITORY_URL");
        public string GitBranch => EnvironmentInfo.EnsureVariable("BITRISE_GIT_BRANCH");
        [CanBeNull] public string GitTag => EnvironmentInfo.Variable("BITRISE_GIT_TAG");
        public string GitCommit => EnvironmentInfo.EnsureVariable("BITRISE_GIT_COMMIT");
        public string GitMessage => EnvironmentInfo.EnsureVariable("BITRISE_GIT_MESSAGE");
        [CanBeNull] public string PullRequest => EnvironmentInfo.Variable("BITRISE_PULL_REQUEST");
        public string ProvisionUrl => EnvironmentInfo.EnsureVariable("BITRISE_PROVISION_URL");
        public string CertificateUrl => EnvironmentInfo.EnsureVariable("BITRISE_CERTIFICATE_URL");
        public string CertificatePassphrase => EnvironmentInfo.EnsureVariable("BITRISE_CERTIFICATE_PASSPHRASE");
    }
}
