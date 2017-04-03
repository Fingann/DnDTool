// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataService.cs" company="BKK">
//   
// </copyright>
// <summary>
//   Defines the IDataService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using DnDTool.Interface;

namespace DnDTool.Model.Services
{
    using DnDTool.Core.Model.Character;

    /// <summary>
    /// The DataService interface.
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// The get data.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        void GetData(Action<DataItem, Exception> callback);
        void GetCharecter(Action<Character, Exception> callback);

    }
}
