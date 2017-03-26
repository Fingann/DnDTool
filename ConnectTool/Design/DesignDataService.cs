// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignDataService.cs" company="BKK">
//   
// </copyright>
// <summary>
//   Defines the DesignDataService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using DnDTool.Interface;
using DnDTool.Model;
using DnDTool.Model.Services;

namespace DnDTool.Design
{
    /// <summary>
    /// The design data service.
    /// </summary>
    public class DesignDataService : IDataService
    {
        /// <summary>
        /// The get data.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data
            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }

    }
}