using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Microbe.Models.ProjectInformationModels
{
    public class company_info
    {
        [Key]
        public int cid { get; set; }
        public string company_name { get; set; }
        public string company_logo_app { get; set; }
        public string company_logo_admin_login { get; set; }
        public string company_sidebar_image_admin { get; set; }
        public string company_address { get; set; }
        public string company_state { get; set; }
        public string company_city { get; set; }
        public string company_zip { get; set; }
        public string company_phone { get; set; }
        public string company_fax { get; set; }
        public string background_color_app { get; set; }
        public string background_color_admin { get; set; }
        public string background_image_app { get; set; }
        public string background_image_admin { get; set; }
        public string table_color_app { get; set; }
        public string table_color_admin { get; set; }
        public string table_background_image_app { get; set; }
        public string table_background_image_admin { get; set; }
        public string email_notification_applicant { get; set; }
        public string email_notification_client { get; set; }
        public string font_color_title_app { get; set; }
        public string font_color_table_app { get; set; }
        public string email_from_address_applicant { get; set; }
        public string email_from_address_client { get; set; }
        public string email_from_address_admin { get; set; }
        public string company_logo_admin { get; set; }
        public string email_from_address { get; set; }
        public string email_from_name { get; set; }
        public string email_notification { get; set; }
        public string email_subject { get; set; }
        public string even_table_row_color { get; set; }
        public string odd_table_row_color { get; set; }
        public string company_website { get; set; }
        public string projectid_type { get; set; }
        public string projectid_start { get; set; }
        public string default_sort { get; set; }
        public string report_location { get; set; }
        public string report_output { get; set; }
        public string smtp_server { get; set; }
        public string smtp_user { get; set; }
        public string smtp_pass { get; set; }
        public string default_date_format { get; set; }
        public string default_time_format { get; set; }
    }
}
