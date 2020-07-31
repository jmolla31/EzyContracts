using System;

namespace EzyContracts
{
    /// <summary>
    /// Identifies a class that can be validated for errors or invalid values. <para />
    /// </summary>
    public interface IValidated
    {
        /// <summary>
        /// Performs a validation over this instance
        /// </summary>
        /// <param name="reason">Validation failure reason, otherwise null</param>
        /// <returns></returns>
        bool Validate(out string reason);
    }
}
