﻿

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.Diagnostics;

[assembly: ExportRenderer(typeof(ViewCell), typeof(Pasasoft.Crm.iOS.StandardViewCellRenderer))]
namespace Pasasoft.Crm.iOS
{
    public class StandardViewCellRenderer : ViewCellRenderer
    {
        public override UIKit.UITableViewCell GetCell(Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            cell.SelectionStyle = UIKit.UITableViewCellSelectionStyle.None;
            Debug.WriteLine("Style Id" + item.StyleId);
            switch (item.StyleId)
            {
                case "checkmark":
                    cell.Accessory = UIKit.UITableViewCellAccessory.Checkmark;
                    break;
                case "detail-button":
                    cell.Accessory = UIKit.UITableViewCellAccessory.DetailButton;
                    break;
                case "detail-disclosure-button":
                    cell.Accessory = UIKit.UITableViewCellAccessory.DetailDisclosureButton;
                    break;
                case "disclosure":
                    cell.Accessory = UIKit.UITableViewCellAccessory.DisclosureIndicator;
                    break;
                default:
                    cell.Accessory = UIKit.UITableViewCellAccessory.None;
                    break;
            }
            return cell;
        }
    }
}
