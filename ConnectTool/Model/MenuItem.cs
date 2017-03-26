// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuItem.cs" company="BKK">
//   
// </copyright>
// <summary>
//   The menu item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using GalaSoft.MvvmLight;

namespace DnDTool.Model
{
    /// <summary>
    /// The menu item.
    /// </summary>
    public class MenuItem: ViewModelBase
    {
        /// <summary>
        /// The name.
        /// </summary>
        private string name;

        /// <summary>
        /// The _content.
        /// </summary>
        private object content;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public object Content
        {
            get
            {
                return this.content;
            }

            set
            {
                this.content = value;
                this.RaisePropertyChanged();
            }
        }
    }
}
