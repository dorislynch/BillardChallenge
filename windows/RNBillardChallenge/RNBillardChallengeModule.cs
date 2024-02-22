using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Billard.Challenge.RNBillardChallenge
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBillardChallengeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBillardChallengeModule"/>.
        /// </summary>
        internal RNBillardChallengeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBillardChallenge";
            }
        }
    }
}
