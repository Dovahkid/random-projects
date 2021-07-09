#ifndef CLOCK_TYPE
#define CLOCK_TYPE

class clockType {

    private:
        float hours;
        float minutes;
        float seconds;
        double dblRepresentation;
        void assign(const double&);
    public:
        void operator=(const double&);
        void print();
        clockType(const double&);

};

#endif