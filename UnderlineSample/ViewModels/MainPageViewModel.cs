using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderlineSample.Common;

namespace UnderlineSample.ViewModels
{
    class MainPageViewModel : BindableBase
    {
        /// <summary>
        /// アンダーラインを引きたい場合こちらに値を入れる
        /// </summary>
        private string _underlineText;

        public string underlineText
        {
            get { return _underlineText; }
            set
            {
                _underlineText = value;
                OnPropertyChanged("underlineText");
            }
        }

        /// <summary>
        /// アンダーラインを引きたくない場合はこちらに値を入れる
        /// </summary>
        private string _normalText;

        public string normalText
        {
            get { return _normalText; }
            set
            {
                _normalText = value;
                OnPropertyChanged("normalText");
            }
        }
    }
}
