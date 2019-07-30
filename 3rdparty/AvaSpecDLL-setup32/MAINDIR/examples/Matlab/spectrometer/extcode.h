#ifndef _extcode_H
#define _extcode_H

#define Private(T)	typedef struct T##_t { void *p; } *T
Private(MagicCookie);
#define kNotAMagicCookie ((MagicCookie)0L)	/* canonical invalid magic cookie */

#define LVRefNum MagicCookie
typedef MagicCookie LVUserEventRef;

extern "C" {

#pragma pack(1)
typedef struct _EventSend 
{
	int handle;
	int result;

} EVENT_SEND;
#pragma pack()



typedef long	MgErr;
 MgErr __cdecl	PostLVUserEvent(LVUserEventRef ref, void *data);
}

#endif /* _extcode_H */
