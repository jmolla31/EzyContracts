using System;
using System.Collections.Generic;
using System.Text;

namespace EzyContracts
{
    /// <summary>
    /// Identifies a core entity (belonging to the internal domain of an application) <para />
    /// This entity must implement a mapping method to an IModel (a model that represents the values of this
    /// entity in a form that can be returned in public responses
    /// </summary>
    public interface ICoreEntity
    {
        TModel ToModel<TModel>();
    }
}
