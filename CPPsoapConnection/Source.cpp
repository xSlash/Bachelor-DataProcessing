#include <stdio.h>
#include "InterfaceSoap.nsmap"
#include "soapInterfaceSoapProxy.h"

int main()
{
    /*InterfaceSoapProxy calc;
	int sum;
	if (calc.HelloAdd(1, 4, sum) == SOAP_OK)
		std::cout << "Sum = " << sum << std::endl;
	else
		calc.soap_stream_fault(std::cerr);
	calc.destroy();*/ // same as: soap_destroy(calc.soap); soap_end(calc.soap);
}
