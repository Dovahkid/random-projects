package calculator;

class hourMath {

    static double percentLife(double hours, double age){

        double hoursAlive = (age*365)*24;

        return (hours/hoursAlive)*100;
    }

    static double percentYears(double hours, double accountAge){

        double accountLife = (accountAge*365)*24;

        return (hours/accountLife)*100;
    }

    static double percentOfYear(double hours){

        return (hours/8760)*100;
    }

}
