import sqlite3
from sqlite3 import Error
 
 
def create_connection (db_file) :
    conn = None
    try :
        conn = sqlite3.connect( db_file )
    except Error as e :
        print ( e )

    return conn
 
 
# def create_project ( conn , project ) :
#     sql = ''' INSERT INTO projects(name,begin_date,end_date)
#             VALUES(?,?,?) '''
#     cur = conn.cursor()
#     cur.execute(sql, project)
#     return cur.lastrowid

def create_vehicles ( conn , vehicle ) :
    sql = \
        ''' 
        INSERT INTO 
        vehicles(veh_vin, veh_name, veh_make, veh_model, veh_year, veh_tag, veh_purch_mi, veh_purch_date, veh_num_doors, veh_eng_size)
        VALUES(?,?,?,?,?,?,?,?,?,?)
        '''
    cur = conn.cursor()
    cur.execute(sql, vehicle)
    return cur.lastrowid

def create_maintenance ( conn , maintenance ) :
    sql = \
        ''' 
        INSERT INTO 
        maintenance(maint_vin, maint_date, maint_mi, maint_by, maint_desc, maint_cost, maint_nxdate, maint_nxmi)
        VALUES(?,?,?,?,?,?,?,?)
        '''
    cur = conn.cursor()
    cur.execute(sql, maintenance)
    return cur.lastrowid
 
 
def main ( ) :
    database = r"veh_log.db"
 
    conn = create_connection (database)
    with conn :
        vehicle = ( '1G456E789546', 'ELECTRIC', 'Tesla' , 'X' , 2019, 'ELECTRIC',  1,  '2019/01/01',  4,  '60kW' )
        maintenance = ('1G456E789546', '2019/10/28', 1 , 'Michael Gain' , 'Waxed car' , 0.0,'', 0)

        create_vehicles(conn, vehicle)
        create_maintenance(conn, maintenance)

    conn.close()
    print("Success! All three tables created!")
    print("End of Project 6 part 2 by Michael Gain")

if __name__ == '__main__':
     main ()