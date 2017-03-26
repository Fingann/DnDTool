// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDisplayable.cs" company="BKK">
//   
// </copyright>
// <summary>
//   Defines the IDisplayable type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DnDTool.Interface
{
    /// <summary>
    /// The Displayable interface.
    /// </summary>
    public interface IDisplayable
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the parameter used for communication between DisplayableViews.
        /// </summary>
        object Parameter { get; set; }
    }
}
