using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp.Models
{
    public class OPRecord
    {
        public Guid ID { get; set; }
        public Guid RecordID { get; set; }
        public Guid TurbineID { get; set; }
        public virtual Record Record { get; set; }
        public virtual Turbine Turbine { get; set; }

        // Hydrological_Data


        public double head_water_level { get; set; }
            public double tail_water_level { get; set; }
            public double operating_head { get; set; }
            public double computed_inflow { get; set; }
            public double average_turbine_discharge { get; set; }
            public double average_spillway_discharge { get; set; }
            public double average_total_station_discharge { get; set; }

        //Generation Today
        public double? generation { get; set; }
        public double? actual_generation_capability { get; set; }
        public double? available_installed_capacity { get; set; }
        //Generation_Data_Yesterday


        public double total_generation { get; set; }
            public double total_generation_in_the_month { get; set; }
            public double total_generation_in_the_year { get; set; }
            public double average_generation { get; set; }
            public double station_peak_generation { get; set; }
            public DateTime time_station_peak_generation { get; set; }
            public string units_on_load { get; set; }
            public string units_available { get; set; }

        // Production_Performace
      
          
            public double total_energy_budgeted_for_the_month { get; set; }
            public double daily_energy_to_achieve_monthly_budget { get; set; }
            public double total_energy_budgeted_for_the_year { get; set; }
            public double energy_achieved_yesterday { get; set; }
            public double cumulative_energy_achieved_in_the_year_yesterday { get; set; }
            public double cumulative_energy_achieved_in_the_month_yesterday { get; set; }

        //Relevant info

        public bool forced_outage { get; set; }
        public bool planned_outage { get; set; }
        public bool spillage { get; set; }
        public double? reservior_level { get; set; }
        public DateTime time_reservior_level_check { get; set; }
        public double? station_auxiliary_consumption { get; set; }
        public DateTime time_station_auxiliary_consumption_check { get; set; }
        public string units_1G5_reports { get; set; }
        public string units_1G6_reports { get; set; }
        public string units_1G7_reports { get; set; }
        public string units_1G8_reports { get; set; }
        public string units_1G9_reports { get; set; }
        public string units_1G10_reports { get; set; }
        public string units_1G11_reports { get; set; }
        public string units_1G12_reports { get; set; }
        public string units_2G1_reports { get; set; }
        public string units_2G2_reports { get; set; }
        public string units_2G3_reports { get; set; }
        public string units_2G4_reports { get; set; }
        public string units_2G5_reports { get; set; }
        public string _330kV_circuit_breaker_T1T2 { get; set; }
        public string SSA_station_service_16_11V_transformer { get; set; }
        public string SST3_station_service_16_11kV { get; set; }
        public string ramp_down { get; set; }
        public double? system_frequency { get; set; }
        public DateTime time_system_frequency_check { get; set; }
        public string _330kV_transmission_line_in_service { get; set; }
        public string _330kV_switchyard_equipment_out_of_service { get; set; }



    }
}
