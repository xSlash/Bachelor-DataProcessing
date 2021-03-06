/* soapStub.h
Generated by gSOAP 2.8.23 from mkws.h

Copyright(C) 2000-2015, Robert van Engelen, Genivia Inc. All Rights Reserved.
The generated code is released under one of the following licenses:
GPL or Genivia's license for commercial use.
This program is released under the GPL with the additional exemption that
compiling, linking, and/or using OpenSSL is allowed.
*/

#ifndef soapStub_H
#define soapStub_H
#define SOAP_NAMESPACE_OF_ns1	"http://grandt.us:90/WebService/"
#include "stdsoap2.h"
#if GSOAP_VERSION != 20823
# error "GSOAP VERSION 20823 MISMATCH IN GENERATED CODE VERSUS LIBRARY CODE: PLEASE REINSTALL PACKAGE"
#endif


/******************************************************************************\
*                                                                            *
* Enumerations                                                               *
*                                                                            *
\******************************************************************************/


/******************************************************************************\
*                                                                            *
* Types with Custom Serializers                                              *
*                                                                            *
\******************************************************************************/


/******************************************************************************\
*                                                                            *
* Classes and Structs                                                        *
*                                                                            *
\******************************************************************************/


#if 0 /* volatile type: do not declare here, declared elsewhere */

#endif

#ifndef SOAP_TYPE__ns1__HelloAdd
#define SOAP_TYPE__ns1__HelloAdd (7)
/* ns1:HelloAdd */
class SOAP_CMAC _ns1__HelloAdd
{
public:
	int a;	/* required element of type xsd:int */
	int b;	/* required element of type xsd:int */
	struct soap *soap;	/* transient */
public:
	virtual int soap_type() const { return 7; } /* = unique type id SOAP_TYPE__ns1__HelloAdd */
	virtual void soap_default(struct soap*);
	virtual void soap_serialize(struct soap*) const;
	virtual int soap_put(struct soap*, const char*, const char*) const;
	virtual int soap_out(struct soap*, const char*, int, const char*) const;
	virtual void *soap_get(struct soap*, const char*, const char*);
	virtual void *soap_in(struct soap*, const char*, const char*);
	_ns1__HelloAdd() { _ns1__HelloAdd::soap_default(NULL); }
	virtual ~_ns1__HelloAdd() { }
};
#endif

#ifndef SOAP_TYPE__ns1__HelloAddResponse
#define SOAP_TYPE__ns1__HelloAddResponse (8)
/* ns1:HelloAddResponse */
class SOAP_CMAC _ns1__HelloAddResponse
{
public:
	int HelloAddResult;	/* SOAP 1.2 RPC return element (when namespace qualified) */	/* required element of type xsd:int */
	struct soap *soap;	/* transient */
public:
	virtual int soap_type() const { return 8; } /* = unique type id SOAP_TYPE__ns1__HelloAddResponse */
	virtual void soap_default(struct soap*);
	virtual void soap_serialize(struct soap*) const;
	virtual int soap_put(struct soap*, const char*, const char*) const;
	virtual int soap_out(struct soap*, const char*, int, const char*) const;
	virtual void *soap_get(struct soap*, const char*, const char*);
	virtual void *soap_in(struct soap*, const char*, const char*);
	_ns1__HelloAddResponse() { _ns1__HelloAddResponse::soap_default(NULL); }
	virtual ~_ns1__HelloAddResponse() { }
};
#endif

#ifndef SOAP_TYPE__ns1__HelloWorld
#define SOAP_TYPE__ns1__HelloWorld (9)
/* ns1:HelloWorld */
class SOAP_CMAC _ns1__HelloWorld
{
public:
	struct soap *soap;	/* transient */
public:
	virtual int soap_type() const { return 9; } /* = unique type id SOAP_TYPE__ns1__HelloWorld */
	virtual void soap_default(struct soap*);
	virtual void soap_serialize(struct soap*) const;
	virtual int soap_put(struct soap*, const char*, const char*) const;
	virtual int soap_out(struct soap*, const char*, int, const char*) const;
	virtual void *soap_get(struct soap*, const char*, const char*);
	virtual void *soap_in(struct soap*, const char*, const char*);
	_ns1__HelloWorld() { _ns1__HelloWorld::soap_default(NULL); }
	virtual ~_ns1__HelloWorld() { }
};
#endif

#ifndef SOAP_TYPE__ns1__HelloWorldResponse
#define SOAP_TYPE__ns1__HelloWorldResponse (10)
/* ns1:HelloWorldResponse */
class SOAP_CMAC _ns1__HelloWorldResponse
{
public:
	char *HelloWorldResult;	/* SOAP 1.2 RPC return element (when namespace qualified) */	/* optional element of type xsd:string */
	struct soap *soap;	/* transient */
public:
	virtual int soap_type() const { return 10; } /* = unique type id SOAP_TYPE__ns1__HelloWorldResponse */
	virtual void soap_default(struct soap*);
	virtual void soap_serialize(struct soap*) const;
	virtual int soap_put(struct soap*, const char*, const char*) const;
	virtual int soap_out(struct soap*, const char*, int, const char*) const;
	virtual void *soap_get(struct soap*, const char*, const char*);
	virtual void *soap_in(struct soap*, const char*, const char*);
	_ns1__HelloWorldResponse() { _ns1__HelloWorldResponse::soap_default(NULL); }
	virtual ~_ns1__HelloWorldResponse() { }
};
#endif

#ifndef SOAP_TYPE__ns1__HelloMike
#define SOAP_TYPE__ns1__HelloMike (11)
/* ns1:HelloMike */
class SOAP_CMAC _ns1__HelloMike
{
public:
	struct soap *soap;	/* transient */
public:
	virtual int soap_type() const { return 11; } /* = unique type id SOAP_TYPE__ns1__HelloMike */
	virtual void soap_default(struct soap*);
	virtual void soap_serialize(struct soap*) const;
	virtual int soap_put(struct soap*, const char*, const char*) const;
	virtual int soap_out(struct soap*, const char*, int, const char*) const;
	virtual void *soap_get(struct soap*, const char*, const char*);
	virtual void *soap_in(struct soap*, const char*, const char*);
	_ns1__HelloMike() { _ns1__HelloMike::soap_default(NULL); }
	virtual ~_ns1__HelloMike() { }
};
#endif

#ifndef SOAP_TYPE__ns1__HelloMikeResponse
#define SOAP_TYPE__ns1__HelloMikeResponse (12)
/* ns1:HelloMikeResponse */
class SOAP_CMAC _ns1__HelloMikeResponse
{
public:
	char *HelloMikeResult;	/* SOAP 1.2 RPC return element (when namespace qualified) */	/* optional element of type xsd:string */
	struct soap *soap;	/* transient */
public:
	virtual int soap_type() const { return 12; } /* = unique type id SOAP_TYPE__ns1__HelloMikeResponse */
	virtual void soap_default(struct soap*);
	virtual void soap_serialize(struct soap*) const;
	virtual int soap_put(struct soap*, const char*, const char*) const;
	virtual int soap_out(struct soap*, const char*, int, const char*) const;
	virtual void *soap_get(struct soap*, const char*, const char*);
	virtual void *soap_in(struct soap*, const char*, const char*);
	_ns1__HelloMikeResponse() { _ns1__HelloMikeResponse::soap_default(NULL); }
	virtual ~_ns1__HelloMikeResponse() { }
};
#endif

#ifndef SOAP_TYPE__ns1__AddLog
#define SOAP_TYPE__ns1__AddLog (13)
/* ns1:AddLog */
class SOAP_CMAC _ns1__AddLog
{
public:
	char *ID;	/* optional element of type xsd:string */
	time_t timestamp;	/* required element of type xsd:dateTime */
	char *action;	/* optional element of type xsd:string */
	struct soap *soap;	/* transient */
public:
	virtual int soap_type() const { return 13; } /* = unique type id SOAP_TYPE__ns1__AddLog */
	virtual void soap_default(struct soap*);
	virtual void soap_serialize(struct soap*) const;
	virtual int soap_put(struct soap*, const char*, const char*) const;
	virtual int soap_out(struct soap*, const char*, int, const char*) const;
	virtual void *soap_get(struct soap*, const char*, const char*);
	virtual void *soap_in(struct soap*, const char*, const char*);
	_ns1__AddLog() { _ns1__AddLog::soap_default(NULL); }
	virtual ~_ns1__AddLog() { }
};
#endif

#ifndef SOAP_TYPE__ns1__AddLogResponse
#define SOAP_TYPE__ns1__AddLogResponse (14)
/* ns1:AddLogResponse */
class SOAP_CMAC _ns1__AddLogResponse
{
public:
	char *AddLogResult;	/* SOAP 1.2 RPC return element (when namespace qualified) */	/* optional element of type xsd:string */
	struct soap *soap;	/* transient */
public:
	virtual int soap_type() const { return 14; } /* = unique type id SOAP_TYPE__ns1__AddLogResponse */
	virtual void soap_default(struct soap*);
	virtual void soap_serialize(struct soap*) const;
	virtual int soap_put(struct soap*, const char*, const char*) const;
	virtual int soap_out(struct soap*, const char*, int, const char*) const;
	virtual void *soap_get(struct soap*, const char*, const char*);
	virtual void *soap_in(struct soap*, const char*, const char*);
	_ns1__AddLogResponse() { _ns1__AddLogResponse::soap_default(NULL); }
	virtual ~_ns1__AddLogResponse() { }
};
#endif

#ifndef SOAP_TYPE___ns1__HelloAdd
#define SOAP_TYPE___ns1__HelloAdd (20)
/* Operation wrapper: */
struct __ns1__HelloAdd
{
public:
	_ns1__HelloAdd *ns1__HelloAdd;	/* optional element of type ns1:HelloAdd */
public:
	int soap_type() const { return 20; } /* = unique type id SOAP_TYPE___ns1__HelloAdd */
};
#endif

#ifndef SOAP_TYPE___ns1__HelloWorld
#define SOAP_TYPE___ns1__HelloWorld (24)
/* Operation wrapper: */
struct __ns1__HelloWorld
{
public:
	_ns1__HelloWorld *ns1__HelloWorld;	/* optional element of type ns1:HelloWorld */
public:
	int soap_type() const { return 24; } /* = unique type id SOAP_TYPE___ns1__HelloWorld */
};
#endif

#ifndef SOAP_TYPE___ns1__HelloMike
#define SOAP_TYPE___ns1__HelloMike (28)
/* Operation wrapper: */
struct __ns1__HelloMike
{
public:
	_ns1__HelloMike *ns1__HelloMike;	/* optional element of type ns1:HelloMike */
public:
	int soap_type() const { return 28; } /* = unique type id SOAP_TYPE___ns1__HelloMike */
};
#endif

#ifndef SOAP_TYPE___ns1__AddLog
#define SOAP_TYPE___ns1__AddLog (32)
/* Operation wrapper: */
struct __ns1__AddLog
{
public:
	_ns1__AddLog *ns1__AddLog;	/* optional element of type ns1:AddLog */
public:
	int soap_type() const { return 32; } /* = unique type id SOAP_TYPE___ns1__AddLog */
};
#endif

#ifndef SOAP_TYPE___ns1__HelloAdd_
#define SOAP_TYPE___ns1__HelloAdd_ (34)
/* Operation wrapper: */
struct __ns1__HelloAdd_
{
public:
	_ns1__HelloAdd *ns1__HelloAdd;	/* optional element of type ns1:HelloAdd */
public:
	int soap_type() const { return 34; } /* = unique type id SOAP_TYPE___ns1__HelloAdd_ */
};
#endif

#ifndef SOAP_TYPE___ns1__HelloWorld_
#define SOAP_TYPE___ns1__HelloWorld_ (36)
/* Operation wrapper: */
struct __ns1__HelloWorld_
{
public:
	_ns1__HelloWorld *ns1__HelloWorld;	/* optional element of type ns1:HelloWorld */
public:
	int soap_type() const { return 36; } /* = unique type id SOAP_TYPE___ns1__HelloWorld_ */
};
#endif

#ifndef SOAP_TYPE___ns1__HelloMike_
#define SOAP_TYPE___ns1__HelloMike_ (38)
/* Operation wrapper: */
struct __ns1__HelloMike_
{
public:
	_ns1__HelloMike *ns1__HelloMike;	/* optional element of type ns1:HelloMike */
public:
	int soap_type() const { return 38; } /* = unique type id SOAP_TYPE___ns1__HelloMike_ */
};
#endif

#ifndef SOAP_TYPE___ns1__AddLog_
#define SOAP_TYPE___ns1__AddLog_ (40)
/* Operation wrapper: */
struct __ns1__AddLog_
{
public:
	_ns1__AddLog *ns1__AddLog;	/* optional element of type ns1:AddLog */
public:
	int soap_type() const { return 40; } /* = unique type id SOAP_TYPE___ns1__AddLog_ */
};
#endif

#ifndef WITH_NOGLOBAL

#ifndef SOAP_TYPE_SOAP_ENV__Header
#define SOAP_TYPE_SOAP_ENV__Header (41)
/* SOAP Header: */
struct SOAP_ENV__Header
{
public:
	int soap_type() const { return 41; } /* = unique type id SOAP_TYPE_SOAP_ENV__Header */
};
#endif

#endif

#ifndef WITH_NOGLOBAL

#ifndef SOAP_TYPE_SOAP_ENV__Code
#define SOAP_TYPE_SOAP_ENV__Code (42)
/* SOAP Fault Code: */
struct SOAP_ENV__Code
{
public:
	char *SOAP_ENV__Value;	/* optional element of type xsd:QName */
	struct SOAP_ENV__Code *SOAP_ENV__Subcode;	/* optional element of type SOAP-ENV:Code */
public:
	int soap_type() const { return 42; } /* = unique type id SOAP_TYPE_SOAP_ENV__Code */
};
#endif

#endif

#ifndef WITH_NOGLOBAL

#ifndef SOAP_TYPE_SOAP_ENV__Detail
#define SOAP_TYPE_SOAP_ENV__Detail (44)
/* SOAP-ENV:Detail */
struct SOAP_ENV__Detail
{
public:
	char *__any;
	int __type;	/* any type of element <fault> (defined below) */
	void *fault;	/* transient */
public:
	int soap_type() const { return 44; } /* = unique type id SOAP_TYPE_SOAP_ENV__Detail */
};
#endif

#endif

#ifndef WITH_NOGLOBAL

#ifndef SOAP_TYPE_SOAP_ENV__Reason
#define SOAP_TYPE_SOAP_ENV__Reason (47)
/* SOAP-ENV:Reason */
struct SOAP_ENV__Reason
{
public:
	char *SOAP_ENV__Text;	/* optional element of type xsd:string */
public:
	int soap_type() const { return 47; } /* = unique type id SOAP_TYPE_SOAP_ENV__Reason */
};
#endif

#endif

#ifndef WITH_NOGLOBAL

#ifndef SOAP_TYPE_SOAP_ENV__Fault
#define SOAP_TYPE_SOAP_ENV__Fault (48)
/* SOAP Fault: */
struct SOAP_ENV__Fault
{
public:
	char *faultcode;	/* optional element of type xsd:QName */
	char *faultstring;	/* optional element of type xsd:string */
	char *faultactor;	/* optional element of type xsd:string */
	struct SOAP_ENV__Detail *detail;	/* optional element of type SOAP-ENV:Detail */
	struct SOAP_ENV__Code *SOAP_ENV__Code;	/* optional element of type SOAP-ENV:Code */
	struct SOAP_ENV__Reason *SOAP_ENV__Reason;	/* optional element of type SOAP-ENV:Reason */
	char *SOAP_ENV__Node;	/* optional element of type xsd:string */
	char *SOAP_ENV__Role;	/* optional element of type xsd:string */
	struct SOAP_ENV__Detail *SOAP_ENV__Detail;	/* optional element of type SOAP-ENV:Detail */
public:
	int soap_type() const { return 48; } /* = unique type id SOAP_TYPE_SOAP_ENV__Fault */
};
#endif

#endif

/******************************************************************************\
*                                                                            *
* Typedefs                                                                   *
*                                                                            *
\******************************************************************************/

#ifndef SOAP_TYPE__QName
#define SOAP_TYPE__QName (5)
typedef char *_QName;
#endif

#ifndef SOAP_TYPE__XML
#define SOAP_TYPE__XML (6)
typedef char *_XML;
#endif


/******************************************************************************\
*                                                                            *
* Externals                                                                  *
*                                                                            *
\******************************************************************************/


#endif

/* End of soapStub.h */
