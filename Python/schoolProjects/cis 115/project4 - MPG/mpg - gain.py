#-------------------------------------------------------------------------------
# Name: Michael Gain
# Date:   9/10/17
# Assignment:  Project 4 - MPA
# Description:
#-------------------------------------------------------------------------------

seg1Miles = 0
seg1MPG = 0
seg2Miles = 0
seg2MPG = 0
desiredMPG = 0
totalGallons = 0
avgMPG = 0
totalMiles = seg1Miles + seg2Miles


def getinfo():
    global seg1Miles, seg1MPG, seg2Miles, seg2MPG, desiredMPG, totalMiles
    seg1Miles = float(input("Enter the miles driven in the First Segment: "))
    seg1MPG = float(input("Enter the MPG of the First Segment: "))
    seg2Miles = float(input("Enter the miles driven in the Second Segment: "))
    seg2MPG = float(input("Enter the MPG of the Second Segment: "))
    desiredMPG = float(input("The the desired Overall MPG: "))
    totalMiles = seg1Miles + seg2Miles
    return 0


def averagempg():
    global totalGallons, avgMPG
    totalGallons = (seg1Miles / seg1MPG) + (seg2Miles / seg2MPG)
    avgMPG = totalGallons / totalMiles
    print("The average MPG were ", avgMPG)


def main():
    getinfo()
    print("The segment 1 miles driven is: ", seg1Miles)
    print("The segment 1 MPG is: ", seg1MPG)
    print("The segment 2 miles driven is: ", seg2Miles)
    print("The segment 2 MPG is: ", seg2MPG)
    averagempg()


main()
