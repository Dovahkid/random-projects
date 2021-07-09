import sqlite3
from sqlite3 import Error
 
 
def create_connection (db_file) :
    conn = None
    try :
        conn = sqlite3.connect(db_file)
        return conn
    except Error as e:
        print (e)

    return conn
 
 
def create_table (conn, create_table_sql):
    try:
        c = conn.cursor()
        c.execute(create_table_sql)
    except Error as e :
        print (e)
 
 
def main ():
    database = r"veh_log.db"

    sql_create_vehicles_table = \
        """
        CREATE TABLE IF NOT EXISTS vehicles
        (
            VEH_VIN text PRIMARY KEY,
            veh_name text NOT NULL,
            veh_make text NOT NULL,
            veh_model text NOT NULL,
            veh_year integer NOT NULL,
            veh_tag text NOT NULL,
            veh_purch_mi integer NOT NULL,
            veh_purch_date text NOT NULL,
            veh_num_doors integer NOT NULL,
            veh_eng_size text NOT NULL
        );
        """

    sql_create_maintenance_table = \
        """
        CREATE TABLE IF NOT EXISTS maintenance
        (
            MAINT_NUM integer PRIMARY KEY AUTOINCREMENT,
            maint_vin text NOT NULL,
            maint_date text NOT NULL,
            maint_mi integer NOT NULL,
            maint_by text NOT NULL,
            maint_desc text NOT NULL,
            maint_cost real NOT NULL,
            maint_nxdate text NOT NULL,
            maint_nxmi integer NOT NULL,
            FOREIGN KEY (maint_vin) REFERENCES vehicles (veh_vin)
        );
        """
 
    sql_create_fuel_purchases_table = \
        """ 
        CREATE TABLE IF NOT EXISTS fuel_purchases 
        (
            FUEL_NUM integer PRIMARY KEY AUTOINCREMENT,
            fuel_vin text NOT NULL,
            fuel_date text NOT NULL,
            fuel_mi integer NOT NULL,
            fuel_used real NOT NULL,
            fuel_cost real,
            fuel_mpgi real,
            fuel_mi_trip real,
            FOREIGN KEY (fuel_vin) REFERENCES vehicles (VEH_VIN)
        ); 
        """
 
    conn = create_connection (database)

    if conn is not None:
        create_table (conn, sql_create_vehicles_table)
        create_table (conn, sql_create_maintenance_table)
        create_table (conn, sql_create_fuel_purchases_table)
        conn.close()

        print("Success! All three tables created!")
        print("End of Project 6 part 1 by Michael Gain")

    else :
        print ("Error! cannot create the database connection.")
 
 
if __name__ == '__main__' :
     main ()