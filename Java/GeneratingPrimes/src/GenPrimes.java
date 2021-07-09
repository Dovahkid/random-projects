public class GenPrimes {

    static void Summation(){ // This method is setup in a weirdish way. My method of finding primes
        // requires this weird setup, but thats okay because this function does a lot

        for(long i = 1; i < 2000000; i+=2) {
            if(FindPrimes(i) && i != 1){ // This confirms the number is a prime

            }
        }
    }

    private static boolean FindPrimes(long i){
        for(long j = 2; j < i; j++){
            if(i % j == 0) {
                return false;
            }
        }
        return true;
    }

}
