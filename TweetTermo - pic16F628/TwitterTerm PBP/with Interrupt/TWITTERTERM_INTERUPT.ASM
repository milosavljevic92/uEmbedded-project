
; PICBASIC PRO(TM) Compiler 3.0.4.1, (c) 1998, 2011 microEngineering Labs, Inc. All Rights Reserved. 
MPASMWIN_USED			EQU	1

#define	PBP_PATH	C:\PBP3\




        NOLIST
    ifdef PM_USED
        LIST
        include 'M16F7x.INC'    ; PM header
        XALL
        NOLIST
    else
        LIST
        LIST p = 16F76, r = dec, w = -302
        INCLUDE "P16F76.INC"    ; MPASM  Header
        NOLIST
    endif
        LIST

#define	EEDATA	PMDATA
#define	EEADR	PMADR
#define	EEDATH	PMDATH
#define	EEADRH	PMADRH
#define	EECON1	PMCON1



PBP_HARDWAREDEF  macro
  endm


    ifdef PM_USED
        device  pic16F76, xt_osc, wdt_on, pwrt_on, protect_off
    else
        __config _XT_OSC & _WDT_ON & _PWRTE_ON & _CP_OFF
    endif



; Define statements.
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00154	DEFINE  CODE_SIZE 8
#define		CODE_SIZE		 8
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00015	DEFINE  DT_INTS_VERSION  110
#define		DT_INTS_VERSION		  110
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00016	DEFINE  INTHAND  INT_ENTRY
#define		INTHAND		  INT_ENTRY
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00017	DEFINE   ReEnterUsed  1
#define		ReEnterUsed		  1
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00018	DEFINE   ReEnterVersion 34  
#define		ReEnterVersion		 34  
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00003	define OSC 4
#define		OSC		 4
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00015	DEFINE LCD_BITS 4
#define		LCD_BITS		 4
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00016	Define LCD_DREG  PORTC
#define		LCD_DREG		  PORTC
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00017	Define LCD_DBIT  0
#define		LCD_DBIT		  0
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00018	Define LCD_RSREG PORTC
#define		LCD_RSREG		 PORTC
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00019	Define LCD_RSBIT 5
#define		LCD_RSBIT		 5
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00020	Define LCD_EREG  PORTC
#define		LCD_EREG		  PORTC
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00021	Define LCD_EBIT  4
#define		LCD_EBIT		  4
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00022	DEFINE LCD_LINES 2
#define		LCD_LINES		 2
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00023	DEFINE LCD_COMMANDUS 2000
#define		LCD_COMMANDUS		 2000
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00024	DEFINE LCD_DATAUS 40
#define		LCD_DATAUS		 40

RAM_START       		EQU	00020h
RAM_END         		EQU	001EFh
RAM_BANKS       		EQU	00004h
BANK0_START     		EQU	00020h
BANK0_END       		EQU	0007Fh
BANK1_START     		EQU	000A0h
BANK1_END       		EQU	000EFh
BANK2_START     		EQU	00110h
BANK2_END       		EQU	0016Fh
BANK3_START     		EQU	00190h
BANK3_END       		EQU	001EFh

; C:\PBP3\PBPPIC14.RAM     	00012	A00020	R0      VAR     WORD BANK0 SYSTEM       ' System Register
R0              		EQU	RAM_START + 000h
; C:\PBP3\PBPPIC14.RAM     	00013	A00022	R1      VAR     WORD BANK0 SYSTEM       ' System Register
R1              		EQU	RAM_START + 002h
; C:\PBP3\PBPPIC14.RAM     	00014	A00024	R2      VAR     WORD BANK0 SYSTEM       ' System Register
R2              		EQU	RAM_START + 004h
; C:\PBP3\PBPPIC14.RAM     	00015	A00026	R3      VAR     WORD BANK0 SYSTEM       ' System Register
R3              		EQU	RAM_START + 006h
; C:\PBP3\PBPPIC14.RAM     	00016	A00028	R4      VAR     WORD BANK0 SYSTEM       ' System Register
R4              		EQU	RAM_START + 008h
; C:\PBP3\PBPPIC14.RAM     	00017	A0002A	R5      VAR     WORD BANK0 SYSTEM       ' System Register
R5              		EQU	RAM_START + 00Ah
; C:\PBP3\PBPPIC14.RAM     	00018	A0002C	R6      VAR     WORD BANK0 SYSTEM       ' System Register
R6              		EQU	RAM_START + 00Ch
; C:\PBP3\PBPPIC14.RAM     	00019	A0002E	R7      VAR     WORD BANK0 SYSTEM       ' System Register
R7              		EQU	RAM_START + 00Eh
; C:\PBP3\PBPPIC14.RAM     	00020	A00030	R8      VAR     WORD BANK0 SYSTEM       ' System Register
R8              		EQU	RAM_START + 010h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00037	A00032	RetAddr     VAR WORD    BANK0   
_RetAddr         		EQU	RAM_START + 012h
; C:\PBP3\PBPPIC14.RAM     	00026	A00034	FLAGS   VAR     BYTE BANK0 SYSTEM       ' Static flags
FLAGS           		EQU	RAM_START + 014h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00036	A00035	fsave       VAR BYTE    BANK0   SYSTEM      ' location for FSR register
fsave           		EQU	RAM_START + 015h
; C:\PBP3\PBPPIC14.RAM     	00025	A00036	GOP     VAR     BYTE BANK0 SYSTEM       ' Gen Op Parameter
GOP             		EQU	RAM_START + 016h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00038	A00037	INT_Bits    VAR BYTE    BANK0
_INT_Bits        		EQU	RAM_START + 017h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00035	A00038	psave       VAR BYTE    BANK0   SYSTEM      ' location for PCLATH register
psave           		EQU	RAM_START + 018h
; C:\PBP3\PBPPIC14.RAM     	00022	A00039	RM1     VAR     BYTE BANK0 SYSTEM       ' Pin 1 Mask
RM1             		EQU	RAM_START + 019h
; C:\PBP3\PBPPIC14.RAM     	00024	A0003A	RM2     VAR     BYTE BANK0 SYSTEM       ' Pin 2 Mask
RM2             		EQU	RAM_START + 01Ah
; C:\PBP3\PBPPIC14.RAM     	00021	A0003B	RR1     VAR     BYTE BANK0 SYSTEM       ' Pin 1 Register
RR1             		EQU	RAM_START + 01Bh
; C:\PBP3\PBPPIC14.RAM     	00023	A0003C	RR2     VAR     BYTE BANK0 SYSTEM       ' Pin 2 Register
RR2             		EQU	RAM_START + 01Ch
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00034	A0003D	ssave       VAR BYTE    BANK0   SYSTEM      ' location for STATUS register
ssave           		EQU	RAM_START + 01Dh
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00041	A0003E	TsaveVars   VAR WORD[MaxTvars]
_TsaveVars       		EQU	RAM_START + 01Eh
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00044	A00046	Poslati         var byte[4]
_Poslati         		EQU	RAM_START + 026h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00048	A0004A	Float			Var Word
_Float           		EQU	RAM_START + 02Ah
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00050	A0004C	Hyst			Var	Word		
_Hyst            		EQU	RAM_START + 02Ch
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00023	A0004E	R0_Save     VAR WORD ;BANK0 SYSTEM
_R0_Save         		EQU	RAM_START + 02Eh
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00024	A00050	R1_Save     VAR WORD ;BANK0 SYSTEM
_R1_Save         		EQU	RAM_START + 030h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00025	A00052	R2_Save     VAR WORD ;BANK0 SYSTEM
_R2_Save         		EQU	RAM_START + 032h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00026	A00054	R3_Save     VAR WORD ;BANK0 SYSTEM
_R3_Save         		EQU	RAM_START + 034h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00027	A00056	R4_Save     VAR WORD ;BANK0 SYSTEM
_R4_Save         		EQU	RAM_START + 036h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00028	A00058	R5_Save     VAR WORD ;BANK0 SYSTEM
_R5_Save         		EQU	RAM_START + 038h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00029	A0005A	R6_Save     VAR WORD ;BANK0 SYSTEM
_R6_Save         		EQU	RAM_START + 03Ah
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00030	A0005C	R7_Save     VAR WORD ;BANK0 SYSTEM
_R7_Save         		EQU	RAM_START + 03Ch
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00031	A0005E	R8_Save     VAR WORD ;BANK0 SYSTEM
_R8_Save         		EQU	RAM_START + 03Eh
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00001	A00060	INCLUDE "DT_INTS-14.bas"    
T1              		EQU	RAM_START + 040h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00001	A00062	INCLUDE "DT_INTS-14.bas"    
T2              		EQU	RAM_START + 042h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00049	A00064	TargetTemp		Var	Word		
_TargetTemp      		EQU	RAM_START + 044h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00047	A00066	TempC			Var Word
_TempC           		EQU	RAM_START + 046h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00046	A00068	Temperature 	Var	Word		
_Temperature     		EQU	RAM_START + 048h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00051	A0006A	V				Var	Word
_V               		EQU	RAM_START + 04Ah
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00056	A0006C	DecMinut        var byte 
_DecMinut        		EQU	RAM_START + 04Ch
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00055	A0006D	DecSat          var byte 
_DecSat          		EQU	RAM_START + 04Dh
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00057	A0006E	DecSec          var byte
_DecSec          		EQU	RAM_START + 04Eh
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00032	A0006F	Flags_Save  VAR BYTE ;BANK0 SYSTEM
_Flags_Save      		EQU	RAM_START + 04Fh
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00045	A00070	wsave           VAR BYTE $70 SYSTEM 
wsave           		EQU	RAM_START + 050h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00033	A00071	GOP_Save    VAR BYTE ;BANK0 SYSTEM
_GOP_Save        		EQU	RAM_START + 051h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00054	A00072	Hours           var byte
_Hours           		EQU	RAM_START + 052h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00053	A00073	Minutes         var byte
_Minutes         		EQU	RAM_START + 053h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00058	A00074	prijem          var byte
_prijem          		EQU	RAM_START + 054h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00034	A00075	RM1_Save    VAR BYTE ;BANK0 SYSTEM
_RM1_Save        		EQU	RAM_START + 055h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00035	A00076	RM2_Save    VAR BYTE ;BANK0 SYSTEM
_RM2_Save        		EQU	RAM_START + 056h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00036	A00077	RR1_Save    VAR BYTE ;BANK0 SYSTEM
_RR1_Save        		EQU	RAM_START + 057h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00037	A00078	RR2_Save    VAR BYTE ;BANK0 SYSTEM
_RR2_Save        		EQU	RAM_START + 058h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00038	A00079	RS1_Save    VAR BYTE ;BANK0 SYSTEM
_RS1_Save        		EQU	RAM_START + 059h
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00039	A0007A	RS2_Save    VAR BYTE ;BANK0 SYSTEM
_RS2_Save        		EQU	RAM_START + 05Ah
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00052	A0007B	Seconds         var byte
_Seconds         		EQU	RAM_START + 05Bh
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00059	A0007C	SIGN            VAR BYTE 
_SIGN            		EQU	RAM_START + 05Ch
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00060	A0007D	Twist			Var byte
_Twist           		EQU	RAM_START + 05Dh
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00155	PORTL   VAR     PORTB
_PORTL           		EQU	 PORTB
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00156	PORTH   VAR     PORTC
_PORTH           		EQU	 PORTC
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00157	TRISL   VAR     TRISB
_TRISL           		EQU	 TRISB
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00158	TRISH   VAR     TRISC
_TRISH           		EQU	 TRISC
_Temperature??LOWBYTE		EQU	_Temperature
_Temperature??HIGHBYTE		EQU	_Temperature + 001h
#define _Serviced        	_INT_Bits??0
#define _Vars_Saved      	_INT_Bits??1
#define _GIE             	_INTCON??7
#define _PEIE            	_INTCON??6
#define _Gore            	_PORTA??3
#define _Dole            	_PORTA??4
#define _OK              	_PORTA??5
#define _RTC_SDA         	_PORTB??2
#define _RTC_SCL         	_PORTB??3
#define _EE_SDA          	_PORTB??0
#define _EE_SCL          	_PORTB??1
#define _TX              	_PORTC??6
#define _RX              	_PORTC??7
#define _DQ              	_PORTB??4
#define _INT_Bits??0     	_INT_Bits, 000h
#define _INT_Bits??1     	_INT_Bits, 001h
#define _INTCON??7       	 INTCON, 007h
#define _INTCON??6       	 INTCON, 006h
#define _PORTA??3        	 PORTA, 003h
#define _PORTA??4        	 PORTA, 004h
#define _PORTA??5        	 PORTA, 005h
#define _PORTB??2        	 PORTB, 002h
#define _PORTB??3        	 PORTB, 003h
#define _PORTB??0        	 PORTB, 000h
#define _PORTB??1        	 PORTB, 001h
#define _PORTC??6        	 PORTC, 006h
#define _PORTC??7        	 PORTC, 007h
#define _PORTB??4        	 PORTB, 004h
#define _Minutes??7      	_Minutes, 007h
#define _Hours??7        	_Hours, 007h
#define _Hours??6        	_Hours, 006h
#define _Temperature??15 	_Temperature + 001h, 007h

; Constants.
_MaxTvars        		EQU	00004h
_RTC             		EQU	000A2h
	INCLUDE	"TWITTERTERM_INTERUPT.MAC"
	INCLUDE	"C:\PBP3\PBPPIC14.LIB"


; C:\PBP3\DEVICES\PIC16F76.PBPINC	00036	#HEADER
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00068	#CONFIG
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00145	BANK0   $0020, $007F
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00146	BANK1   $00A0, $00EF
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00147	BANK2   $0110, $016F
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00148	BANK3   $0190, $01EF
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00151	    #ERROR "-n option (PBPL) is not supported for this device."
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00152	#ENDIF
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00153	LIBRARY "PBPPIC14"
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00154	DEFINE  CODE_SIZE 8

; C:\PBP3\DEVICES\PIC16F76.PBPINC	00159	include "PBPPIC14.RAM"
; C:\PBP3\DEVICES\PIC16F76.PBPINC	00163	#HEADER

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00001	INCLUDE "DT_INTS-14.bas"    
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00015	DEFINE  DT_INTS_VERSION  110
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00016	DEFINE  INTHAND  INT_ENTRY

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00045	ASM

	ASM?

  ifdef PM_USED                             ; verify MPASM is the assembler
    "ERROR: DT_INTS does not support the PM assembler, USE MPASM"
  endif

;---------------------------------------------------------------------------
  ifdef ReEnterUsed
    ifdef ReEnterVersion
      if (ReEnterVersion < 34)
        error "Wrong version of ReEnterPBP.bas - Ver 3.4 or higher required
      endif
    else
      error "Wrong version of ReEnterPBP.bas - Ver 3.4 or higher required
    endif
  endif

;---------------------------------------------------------------------------
    if (BANK0_END == 0x7F)
      ifdef BANK1_END
        if (BANK1_END == 0xEF)   ; doesn't find 12F683
          variable ACCESSRAM = 1
        else
          variable ACCESSRAM = 0    
        endif
      else
          variable ACCESSRAM = 0
      endif
    else
      variable ACCESSRAM = 0
    endif
    
;---------------------------------------------------------------------------
#define OrChange Or change to   wsave BYTE $70 SYSTEM
AddWsave macro B
  if (B == 0)
    if (ACCESSRAM == 1)
      error   "                     Add:"       wsave VAR BYTE $70 SYSTEM
    else
      error   "                     Add:"       wsave VAR BYTE $20 SYSTEM
    endif
  endif
  if (B == 1)
    if (ACCESSRAM == 1)
      error   "   Add:"       wsave1 VAR BYTE $A0 SYSTEM, OrChange
    else
      error   "                     Add:"       wsave1 VAR BYTE $A0 SYSTEM
    endif
  endif
  if (B == 2)
    if (ACCESSRAM == 1)
      error   "   Add:"       wsave2 VAR BYTE $120 SYSTEM, OrChange
    else
      error   "                     Add:"       wsave2 VAR BYTE $120 SYSTEM
    endif
  endif
  if (B == 3)
    if (ACCESSRAM == 1)
      error   "   Add:"       wsave3 VAR BYTE $1A0 SYSTEM, OrChange
    else
      error   "                     Add:"       wsave3 VAR BYTE $1A0 SYSTEM
    endif
  endif
  endm
  
#define WsaveE1(B) Chip has RAM in BANK#v(B), but wsave#v(B) was not found.
;#define WsaveE2(B) Uncomment wsave#v(B) in the DT_INTS-14.bas file.
#define WsaveCouldBe This chip has access RAM at $70
  
#define WsaveError(B) error  WsaveE1(B)
  ifndef FSR0L     ; not a 16F1
    ifndef wsave
;      if (ACCESSRAM == 1)
        error wsave variable not found,
        AddWsave(0)
        variable wsave = 0 ; stop further wsave errors
;      else
        
;      endif
    else
      if (wsave == 0x70)
        if (ACCESSRAM == 0)
          error This chip does not have AccessRAM at $70, change to   wsave VAR BYTE $20 SYSTEM
        endif
      else
          if (wsave != 0x20)
            error wsave must be either $20 or $70
          endif
      endif
    endif
    ifdef BANK1_START
      ifndef wsave1
        ifdef wsave
          if (wsave != 0x70)
            WsaveError(1)
            AddWsave(1)
          endif
        else
          if (ACCESSRAM == 1)
            if (wsave != 0x70)
              WsaveCouldBe 
            endif
          endif
        endif
      endif
    endif
    ifdef BANK2_START
      ifndef wsave2
        ifdef wsave
          if (wsave != 0x70)
            WsaveError(2)
            AddWsave(2)
          endif
        endif
      endif
    endif
    ifdef BANK3_START
      ifndef wsave3
        ifdef wsave
          if (wsave != 0x70)
            WsaveError(3)
            AddWsave(3)
          endif
        endif
      endif
    endif
  
        
  endif


	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00175	ASM

	ASM?

asm = 0
Asm = 0
ASM = 0
pbp = 1
Pbp = 1
PBP = 1
yes = 1
Yes = 1
YES = 1
no  = 0
No  = 0
NO  = 0


  #define ALL_INT      INTCON,GIE, INTCON,GIE      ;-- Global Interrupts   *
  #define T1GATE_INT   PIR1,TMR1GIF, PIE1,TMR1GIE  ;-- Timer1 Gate         *
  #define INT_INT      INTCON,INTF,  INTCON,INTE   ;-- External INT
  #define GPC_INT      INTCON,GPIF,  INTCON,GPIE   ;-- GPIO Int On Change  *
  #define IOC_INT      INTCON,IOCIF, INTCON,IOCIE  ;-- Int On Change       *
  #define RAC_INT      INTCON,RAIF,  INTCON,RAIE   ;-- RA Port Change      *
  #define RBC_INT      INTCON,RBIF,  INTCON,RBIE   ;-- RB Port Change
  #define RABC_INT     INTCON,RABIF, INTCON,RABIE  ;-- RAB Port Change     *
  ifdef T0IF
    #define TMR0_INT   INTCON,T0IF, INTCON,T0IE    ;-- TMR0 Overflow
  else
    ifdef TMR0IF
      #define TMR0_INT INTCON,TMR0IF, INTCON,TMR0IE ;-- TMR0 alternate sym
    endif
  endif
  ifdef TMR1IF
    #define TMR1_INT   PIR1,TMR1IF, PIE1,TMR1IE    ;-- TMR1 Overflow
  else
    ifdef T1IF
      #define TMR1_INT PIR1,T1IF, PIE1,T1IE        ;-- TMR1 alternate sym
    endif
  endif
  ifdef TMR2IF
    #define TMR2_INT   PIR1,TMR2IF, PIE1,TMR2IE    ;-- TMR2 - PR2 Match 
  else
    #define TMR2_INT   PIR1,T2IF, PIE1,T2IE        ;-- TMR2 - PR2 Match alt
  endif
  #define TMR4_INT     PIR3,TMR4IF, PIE3,TMR4IE    ;-- TMR4 - PR4 Match    *
  #define TMR6_INT     PIR3,TMR6IF, PIE3,TMR6IE    ;-- TMR6 - PR6 Match    *
  #define TX_INT       PIR1,TXIF, PIE1,TXIE        ;-- USART Transmit 
  #define RX_INT       PIR1,RCIF, PIE1,RCIE        ;-- USART Receive 

  #define PSP_INT      PIR1,PSPIF, PIE1,PSPIE      ;-- Parallel Slave Port
  #define AD_INT       PIR1,ADIF, PIE1,ADIE        ;-- A/D Converter 

  ifdef SSPIF
    #define SSP_INT    PIR1,SSPIF, PIE1,SSPIE      ;-- (M)SSP module
    #define BUS_INT    PIR2,BCLIF, PIE2,BCLIE      ;-- Bus Collision 
  else
    ifdef SSP1IF
      #define SSP_INT  PIR1,SSP1IF, PIE1,SSP1IE    ;-- (M)SSP module 1     *
      #define SSP1_INT PIR1,SSP1IF, PIE1,SSP1IE    ;                       *
      #define BUS_INT  PIR2,BCL1IF, PIE2,BCL1IE    ;-- Bus Collision 1     *
      #define BUS1_INT PIR2,BCL1IF, PIE2,BCL1IE    ;                       *
    endif
    ifdef SSP2IF
      #define SSP2_INT PIR4,SSP2IF, PIE4,SSP2IE    ;-- (M)SSP module 2     *
      #define BUS2_INT PIR4,BCL2IF, PIE4,BCL2IE    ;-- Bus Collision 2     *
    endif
  endif      
  #define CCP1_INT     PIR1,CCP1IF, PIE1,CCP1IE    ;-- CCP1 
  #define CCP2_INT     PIR2,CCP2IF, PIE2,CCP2IE    ;-- CCP2 
  #define CCP3_INT     PIR3,CCP3IF, PIE3,CCP3IE    ;-- CCP3                *
  #define CCP4_INT     PIR3,CCP4IF, PIE3,CCP4IE    ;-- CCP4                *
  #define CCP5_INT     PIR3,CCP5IF, PIE3,CCP5IE    ;-- CCP5                *

  ifdef CMIF
    ifdef PIR2
      #define CMP_INT  PIR2,CMIF, PIE2,CMIE        ;-- Comparator
    else
      #define CMP_INT  PIR1,CMIF, PIE1,CMIE
    endif
  else
    ifdef C1IF
      #define CMP_INT  PIR2,C1IF, PIE2,C1IE        ;-- Comparator 1        *
      #define CMP1_INT PIR2,C1IF, PIE2,C1IE        ;-- Comparator 1        *
    endif
    ifdef C2IF
      #define CMP2_INT PIR2,C2IF, PIE2,C2IE        ;-- Comparator 2        *
    endif
  endif
   
  ifndef PIR2
    #define EE_INT     PIR1,EEIF, PIE1,EEIE
    #define OSCF_INT   PIR1,OSFIF, PIE1,OSFIE      ;-- OSC Fail if no PIR2 *
    #define LVD_INT    PIR1,LVDIF, PIE1,LVDIE      ;-- Low-Voltage Detect  *
  else
    #define EE_INT     PIR2,EEIF, PIE2,EEIE        ;-- EEPROM/FLASH Write
    #define OSCF_INT   PIR2,OSFIF, PIE2,OSFIE      ;-- OSC Fail            *
    #define LVD_INT    PIR2,LVDIF, PIE2,LVDIE      ;-- Low-Voltage Detect  *
  endif
  
  #define LCD_INT      PIR2,LCDIF, PIE2,LCDIE      ;-- LCD controller      *
  #define CRYPT_INT    PIR1,CRIF, PIE1,CRIE        ;-- KeeLoq Cryptographic*
  #define USB_INT      PIR1,USBIF, PIE1,USBIE      ;-- USB 16C745/765 only *


	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00278	ASM

	ASM?

;---[Returns the Address of a Label as a Word]------------------------------
GetAddress macro Label, Wout
    CHK?RP Wout
    movlw low Label          ; get low byte
    movwf Wout
;    movlw High Label         ; get high byte  MPLAB 8.53 killed high
    movlw Label >> 8         ; get high byte
    movwf Wout + 1
  endm

;---[find correct bank for a BIT variable]----------------------------------
CHKRP?T  macro reg, bit
    CHK?RP  reg
  endm
    
;---[This creates the main Interrupt Service Routine (ISR)]-----------------
INT_CREATE  macro
  local OverCREATE
    L?GOTO OverCREATE

INT_ENTRY
    ifndef FSR0L  
      if (CODE_SIZE <= 2)
          movwf   wsave       ; 1 copy W to wsave register
          swapf   STATUS,W    ; 2 swap status reg to be saved into W
          clrf    STATUS      ; 3 change to bank 0
          movwf   ssave       ; 4 save status reg to a bank 0 register
          movf    PCLATH,W    ; 5 move PCLATH reg to be saved into W reg
          movwf   psave       ; 6 save PCLATH reg to a bank 0 register
      endIF
      movf      FSR,W         ; 7 move FSR reg to be saved into W reg
      movwf     fsave         ; 8 save FSR reg to a bank 0 register
    else
      banksel 0               ; BANK 0 for F1 chips
    endif  
    variable  PREV_BANK = 0
    MOVE?CT  0, _Vars_Saved
    
List_Start
    ifdef LoopWhenServiced
      MOVE?CT  0, _Serviced   ; indicate nothing has been serviced
    endif

    INT_LIST                  ; Expand the users list of interrupt handlers
                            ; INT_LIST macro must be defined in main program
    
    ifdef LoopWhenServiced
      BIT?GOTO  1, _Serviced, List_Start
    endif

    ifdef ReEnterUsed         ; if ReEnterPBP.bas was included
        CHKRP?T  _Vars_Saved
        btfss    _Vars_Saved  ; if PBP system vars have been saved 
        goto     INT_EXIT
        L?GOTO   _RestorePBP  ; Restore PBP system Vars
    endif
    
INT_EXIT
    variable  PREV_BANK = 0
    ifndef FSR0L              ; if chip is not an F1 - restore context
      clrf    STATUS          ; BANK 0
      movf    fsave,W         ; Restore the FSR reg
      movwf   FSR
      movf    psave,w         ; Restore the PCLATH reg
      movwf   PCLATH
      swapf   ssave,w         ; Restore the STATUS reg
      movwf   STATUS
      swapf   wsave,f
      swapf   wsave,w         ; Restore W reg
    endif
    retfie                    ; Exit the interrupt routine
;-----------------------------
  LABEL?L OverCREATE
    bsf      INTCON, 6      ; Enable Peripheral interrupts
    bsf      INTCON, 7      ; Enable Global interrupts
    endm
    


	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\DT_INTS-14.BAS	00358	ASM

	ASM?

;---[Add an Interrupt Source to the user's list of INT Handlers]------------
#INT_HANDLER  macro  FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset
  list
    local AfterSave, AfterUserRoutine, NoInt
      ifdef FlagBit
        CHK?RP   EnableReg
        btfss    EnableReg, EnableBit        ; if the INT is enabled
        goto     NoInt
        CHK?RP   FlagReg                    
        btfss    FlagReg, FlagBit            ; and the Flag set?
        goto     NoInt
        ifdef LoopWhenServiced
          MOVE?CT  1, _Serviced
        endif
            
        if (Type == PBP)                     ; If INT handler is PBP
          ifdef ReEnterUsed
            btfsc  _Vars_Saved
            goto   AfterSave
            GetAddress  AfterSave, _RetAddr  
            L?GOTO  _SavePBP                 ; Save PBP system Vars
            LABEL?L  AfterSave
          else
            error ReEnterPBP must be INCLUDEd to use PBP type interrupts
          endif
        endif
        GetAddress  AfterUserRoutine, _RetAddr   ; save return address
        L?GOTO   Label                       ; goto the users INT handler
        LABEL?L AfterUserRoutine

        if (Reset == YES)
          CHK?RP   FlagReg
          bcf      FlagReg, FlagBit        ; reset flag (if specified)
        endif
      else
        INT_ERROR  "INT_Handler"
      endif
NoInt
      banksel  0
PREV_BANK = 0        
    endm
;-----------------------------------
#define INT_HANDLER(FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset)  #INT_HANDLER FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset
  ifndef INT_Handler
#define INT_Handler(FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset)  #INT_HANDLER FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset
#define int_handler(FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset)  #INT_HANDLER FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset
#define Int_Handler(FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset)  #INT_HANDLER FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset
#define Int_handler(FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset)  #INT_HANDLER FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset
#define int_Handler(FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset)  #INT_HANDLER FlagReg,FlagBit, EnableReg,EnableBit, Label, Type,Reset
  endif
  
;---[Returns from a "goto" subroutine]--------(RetAddr must be set first)---
#INT_RETURN  macro
      CHK?RP  _RetAddr
      movf    _RetAddr + 1, W  ; Set PCLATH with top byte of return address
      movwf   PCLATH
      movf    _RetAddr, W      ; Go back to where we were
      movwf   PCL
    endm    
;_____________________________
#define INT_RETURN  #INT_RETURN
  ifndef INT_Return
#define INT_Return  #INT_RETURN 
#define int_return  #INT_RETURN 
#define Int_Return  #INT_RETURN 
#define Int_return  #INT_RETURN 
#define int_Return  #INT_RETURN 
  endif

;----[Display not found error]----------------------------------------------
INT_ERROR macro From
    error From -  Interrupt Flag ( FlagReg,FlagBit ) not found.
  endm

;---[Enable an interrupt source]--------------------------------------------
  ifndef INT_ENABLECLEARFIRST
    #define INT_ENABLECLEARFIRST 1             ; default to Clear First
  endif          ; use DEFINE INT_ENABLECLEARFIRST 0 to NOT clear First
  
#INT_ENABLE  macro  FlagReg, FlagBit, EnableReg, EnableBit
      ifdef FlagBit
        ifdef INT_ENABLECLEARFIRST
          if (INT_ENABLECLEARFIRST == 1)       ; if specified
            MOVE?CT 0, FlagReg, FlagBit        ;   clear the flag first
          endif
        endif
        MOVE?CT  1, EnableReg, EnableBit       ; enable the INT source
      else
        INT_ERROR  "INT_ENABLE"
      endif
    endm    
;_____________________________
#define INT_ENABLE(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_ENABLE FlagReg, FlagBit, EnableReg, EnableBit
  ifndef INT_Enable
#define INT_Enable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_ENABLE FlagReg, FlagBit, EnableReg, EnableBit
#define int_enable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_ENABLE FlagReg, FlagBit, EnableReg, EnableBit
#define Int_Enable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_ENABLE FlagReg, FlagBit, EnableReg, EnableBit
#define Int_enable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_ENABLE FlagReg, FlagBit, EnableReg, EnableBit
#define int_Enable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_ENABLE FlagReg, FlagBit, EnableReg, EnableBit
  endif

;---[Disable an interrupt source]-------------------------------------------
#INT_DISABLE  macro  FlagReg, FlagBit, EnableReg, EnableBit
      ifdef FlagBit
        MOVE?CT  0, EnableReg, EnableBit       ; disable the INT source  
      else
        INT_ERROR  "INT_DISABLE"
      endif
    endm    
;_____________________________
#define INT_DISABLE(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_DISABLE FlagReg, FlagBit, EnableReg, EnableBit
  ifndef INT_Disable
#define INT_Disable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_DISABLE FlagReg, FlagBit, EnableReg, EnableBit
#define int_disable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_DISABLE FlagReg, FlagBit, EnableReg, EnableBit
#define Int_Disable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_DISABLE FlagReg, FlagBit, EnableReg, EnableBit
#define Int_disable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_DISABLE FlagReg, FlagBit, EnableReg, EnableBit
#define int_Disable(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_DISABLE FlagReg, FlagBit, EnableReg, EnableBit
  endif

;---[Clear an interrupt Flag]-----------------------------------------------
#INT_CLEAR  macro  FlagReg, FlagBit, EnableReg, EnableBit
      ifdef FlagBit
        MOVE?CT  0, FlagReg, FlagBit           ; clear the flag
      else
        INT_ERROR "INT_CLEAR" 
      endif
    endm
;_____________________________
#define INT_CLEAR(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_CLEAR FlagReg, FlagBit, EnableReg, EnableBit
  ifndef INT_Clear
#define INT_Clear(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_CLEAR FlagReg, FlagBit, EnableReg, EnableBit
#define int_clear(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_CLEAR FlagReg, FlagBit, EnableReg, EnableBit
#define Int_Clear(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_CLEAR FlagReg, FlagBit, EnableReg, EnableBit
#define Int_clear(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_CLEAR FlagReg, FlagBit, EnableReg, EnableBit
#define int_Clear(FlagReg, FlagBit, EnableReg, EnableBit)  #INT_CLEAR FlagReg, FlagBit, EnableReg, EnableBit
  endif


	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00002	INCLUDE "ReEnterPBP.bas"  
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00015	MaxTvars    CON 4
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00017	DEFINE   ReEnterUsed  1
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00018	DEFINE   ReEnterVersion 34  

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00020	goto OverReEnter
	GOTO?L	_OverReEnter

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00043	ASM

	ASM?

ChkTvar   macro Name, LastTvar
    ifdef Name
      error Temp variables exceeding LastTvar "Increase the MaxTvars constant"
    endif
  endm
  
SaveTvar  macro Name, Svar
    ifdef Name
        MOVE?WW  Name, Svar
    endif
  endm

RestTvar  macro Name, Svar
    ifdef Name
        MOVE?WW  Svar, Name
    endif
  endm


	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00063	SavePBP:                ' Save all PBP system Vars

	LABEL?L	_SavePBP	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00064	    R0_Save = R0        '  4/ 4
	MOVE?WW	R0, _R0_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00065	    R1_Save = R1        '  4/ 8
	MOVE?WW	R1, _R1_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00066	    R2_Save = R2        '  4/12
	MOVE?WW	R2, _R2_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00067	    R3_Save = R3        '  4/16
	MOVE?WW	R3, _R3_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00068	    R4_Save = R4        '  4/20
	MOVE?WW	R4, _R4_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00069	    R5_Save = R5        '  4/24
	MOVE?WW	R5, _R5_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00070	    R6_Save = R6        '  4/28
	MOVE?WW	R6, _R6_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00071	    R7_Save = R7        '  4/32
	MOVE?WW	R7, _R7_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00072	    R8_Save = R8        '  4/36
	MOVE?WW	R8, _R8_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00073	    Flags_Save = FLAGS  '  2/38
	MOVE?BB	FLAGS, _Flags_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00074	    GOP_Save = GOP      '  2/40
	MOVE?BB	GOP, _GOP_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00075	    RM1_Save = RM1      '  2/42
	MOVE?BB	RM1, _RM1_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00076	    RM2_Save = RM2      '  2/44
	MOVE?BB	RM2, _RM2_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00077	    RR1_Save = RR1      '  2/46
	MOVE?BB	RR1, _RR1_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00078	    RR2_Save = RR2      '  2/48
	MOVE?BB	RR2, _RR2_Save

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00079	    ASM

	ASM?

        ifdef RS1
            MOVE?BB    RS1, _RS1_Save    ; 2/50
        endif
        ifdef RS2
            MOVE?BB    RS2, _RS2_Save    ; 2/52
        endif

        variable Tcount = 1              ; 4 per Tvar
        while (Tcount <= _MaxTvars)
          SaveTvar T#v(Tcount), _TsaveVars + ((Tcount-1) << 1)
          variable Tcount = Tcount + 1
        endw
        ChkTvar  T#v(Tcount), T#v(Tcount-1)
    

	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00095	    Vars_Saved = 1
	MOVE?CT	001h, _Vars_Saved

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00096	@ INT_RETURN

	ASM?
 INT_RETURN

	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00098	RestorePBP:

	LABEL?L	_RestorePBP	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00099	    R0 = R0_Save
	MOVE?WW	_R0_Save, R0

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00100	    R1 = R1_Save
	MOVE?WW	_R1_Save, R1

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00101	    R2 = R2_Save
	MOVE?WW	_R2_Save, R2

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00102	    R3 = R3_Save
	MOVE?WW	_R3_Save, R3

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00103	    R4 = R4_Save
	MOVE?WW	_R4_Save, R4

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00104	    R5 = R5_Save
	MOVE?WW	_R5_Save, R5

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00105	    R6 = R6_Save
	MOVE?WW	_R6_Save, R6

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00106	    R7 = R7_Save
	MOVE?WW	_R7_Save, R7

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00107	    R8 = R8_Save
	MOVE?WW	_R8_Save, R8

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00108	    FLAGS = Flags_Save
	MOVE?BB	_Flags_Save, FLAGS

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00109	    GOP = GOP_Save
	MOVE?BB	_GOP_Save, GOP

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00110	    RM1 = RM1_Save
	MOVE?BB	_RM1_Save, RM1

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00111	    RM2 = RM2_Save
	MOVE?BB	_RM2_Save, RM2

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00112	    RR1 = RR1_Save
	MOVE?BB	_RR1_Save, RR1

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00113	    RR2 = RR2_Save
	MOVE?BB	_RR2_Save, RR2

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00114	    ASM

	ASM?

        ifdef RS1
            MOVE?BB     _RS1_Save, RS1
        endif
        ifdef RS2
            MOVE?BB     _RS2_Save, RS2
        endif
        
        variable Tcount = 1                ; restore Temp vars
        while (Tcount <= _MaxTvars)
          RestTvar T#v(Tcount), _TsaveVars + ((Tcount-1) << 1)
          variable Tcount = Tcount + 1
        endw
    

	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00128	   Vars_Saved = 0
	MOVE?CT	000h, _Vars_Saved

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00129	@  L?GOTO INT_EXIT

	ASM?
  L?GOTO INT_EXIT

	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\REENTERPBP.BAS	00132	OverReEnter:

	LABEL?L	_OverReEnter	
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00003	define OSC 4

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00005	ASM

	ASM?

INT_LIST  macro    
        INT_Handler   TMR1_INT,  _ProveriSlanjeTemp,   PBP,  yes
    endm
    INT_CREATE               


	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00012	T1CON = $31           
	MOVE?CB	031h, T1CON

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00013	@ INT_ENABLE  TMR1_INT     

	ASM?
 INT_ENABLE  TMR1_INT     

	ENDASM?

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00015	DEFINE LCD_BITS 4
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00016	Define LCD_DREG  PORTC
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00017	Define LCD_DBIT  0
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00018	Define LCD_RSREG PORTC
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00019	Define LCD_RSBIT 5
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00020	Define LCD_EREG  PORTC
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00021	Define LCD_EBIT  4
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00022	DEFINE LCD_LINES 2
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00023	DEFINE LCD_COMMANDUS 2000
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00024	DEFINE LCD_DATAUS 40
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00026	symbol Gore     = PORTA.3
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00027	symbol Dole     = PORTA.4
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00028	Symbol OK       = PORTA.5
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00029	symbol RTC_SDA  = PORTB.2
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00030	symbol RTC_SCL  = PORTB.3
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00031	SYMBOL EE_SDA   = PORTB.0
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00032	SYMBOL EE_SCL   = PORTB.1
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00033	SYMBOL TX       = PORTC.6
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00034	SYMBOL RX       = PORTC.7
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00035	symbol DQ       = PORTB.4

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00037	OUTPUT TX
	OUTPUT?T	_TX

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00038	input  dq
	INPUT?T	_DQ

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00039	INPUT  RX
	INPUT?T	_RX

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00040	INPUT  OK
	INPUT?T	_OK

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00041	INPUT  GORE
	INPUT?T	_Gore

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00042	INPUT  DOLE
	INPUT?T	_Dole

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00061	ADCON1          =   $0F
	MOVE?CB	00Fh, ADCON1
; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00062	RTC             con %10100010

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00063	pause 200
	PAUSE?C	0C8h

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00064	Lcdout $fe, 1
	LCDOUT?C	0FEh
	LCDOUT?C	001h

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00065	gosub PodesiVreme
	GOSUB?L	_PodesiVreme

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00067	Main:

	LABEL?L	_Main	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00068	    gosub IzmeriTemperaturu
	GOSUB?L	_IzmeriTemperaturu

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00069	    Lcdout $fe, 2,"Temp",sign, dec2 (Temperature / 100) ,dec2 temperature, 223,"C             "
	LCDOUT?C	0FEh
	LCDOUT?C	002h
	LCDOUT?C	054h
	LCDOUT?C	065h
	LCDOUT?C	06Dh
	LCDOUT?C	070h
	LCDOUT?B	_SIGN
	LCDOUTCOUNT?C	002h
	DIV?WCW	_Temperature, 064h, T1
	LCDOUTNUM?W	T1
	LCDOUTDEC?	
	LCDOUTCOUNT?C	002h
	LCDOUTNUM?W	_Temperature
	LCDOUTDEC?	
	LCDOUT?C	0DFh
	LCDOUT?C	043h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00070	    Lcdout $fe, $c0, "Time: ",dec2 decsat,":",dec2 decminut,":",dec2 decsec ,"               "
	LCDOUT?C	0FEh
	LCDOUT?C	0C0h
	LCDOUT?C	054h
	LCDOUT?C	069h
	LCDOUT?C	06Dh
	LCDOUT?C	065h
	LCDOUT?C	03Ah
	LCDOUT?C	020h
	LCDOUTCOUNT?C	002h
	LCDOUTNUM?B	_DecSat
	LCDOUTDEC?	
	LCDOUT?C	03Ah
	LCDOUTCOUNT?C	002h
	LCDOUTNUM?B	_DecMinut
	LCDOUTDEC?	
	LCDOUT?C	03Ah
	LCDOUTCOUNT?C	002h
	LCDOUTNUM?B	_DecSec
	LCDOUTDEC?	
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h
	LCDOUT?C	020h

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00071	    PAUSE 50
	PAUSE?C	032h

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00072	GOTO MAIN
	GOTO?L	_Main

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00074	UzmiVreme:

	LABEL?L	_UzmiVreme	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00075	    i2cread rtc_sda,rtc_scl,rtc,$02,[seconds,minutes,hours]
	I2CDATA?T	_RTC_SDA
	I2CCLOCK?T	_RTC_SCL
	I2CWRITE?C	_RTC
	I2CWRITE?C	002h
	I2CREAD?B	_Seconds
	I2CREAD?B	_Minutes
	I2CREADS?B	_Hours

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00076	    minutes.7=0:hours.7=0:hours.6=0
	MOVE?CT	000h, _Minutes??7

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00076	    minutes.7=0:hours.7=0:hours.6=0
	MOVE?CT	000h, _Hours??7

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00076	    minutes.7=0:hours.7=0:hours.6=0
	MOVE?CT	000h, _Hours??6

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00077	    DecMinut = ((minutes  & %11110000)>>4)  * 10 + (minutes & %00001111)
	AND?BCW	_Minutes, 0F0h, T1
	SHIFTR?WCW	T1, 004h, T1
	MUL?WCW	T1, 00Ah, T1
	AND?BCW	_Minutes, 00Fh, T2
	ADD?WWB	T1, T2, _DecMinut

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00078	    decsat = ((Hours & %11110000)>>4)  * 10 + (hours & %00001111)
	AND?BCW	_Hours, 0F0h, T1
	SHIFTR?WCW	T1, 004h, T1
	MUL?WCW	T1, 00Ah, T1
	AND?BCW	_Hours, 00Fh, T2
	ADD?WWB	T1, T2, _DecSat

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00079	    decsec = ((Seconds  & %11110000)>>4)  * 10 + (seconds  & %00001111)
	AND?BCW	_Seconds, 0F0h, T1
	SHIFTR?WCW	T1, 004h, T1
	MUL?WCW	T1, 00Ah, T1
	AND?BCW	_Seconds, 00Fh, T2
	ADD?WWB	T1, T2, _DecSec

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00080	    pause 10
	PAUSE?C	00Ah

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00081	return
	RETURN?	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00083	PodesiVreme: 

	LABEL?L	_PodesiVreme	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00084	    I2cwrite rtc_sda,rtc_scl,rtc,$02,[$00,$00,$00,$01,$02,$01,$01]
	I2CDATA?T	_RTC_SDA
	I2CCLOCK?T	_RTC_SCL
	I2CWRITE?C	_RTC
	I2CWRITE?C	002h
	I2CWRITE?C	000h
	I2CWRITE?C	000h
	I2CWRITE?C	000h
	I2CWRITE?C	001h
	I2CWRITE?C	002h
	I2CWRITE?C	001h
	I2CWRITES?C	001h

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00085	    pause 10
	PAUSE?C	00Ah

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00086	return
	RETURN?	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00088	ProveriSlanjeTemp:

	LABEL?L	_ProveriSlanjeTemp	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00089	    serin2  rx,396,NemaPodataka,[wait ("TC")]
	SERIN2DPIN?T	_RX
	SERIN2MODE?C	0018Ch

	LABEL?L	L00001	
	SERIN2WAITP?CLL	054h, L00001, _NemaPodataka
	SERIN2WAITP?CLL	043h, L00001, _NemaPodataka

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00090	    poslati[1] = (Temperature / 100)
	DIV?WCB	_Temperature, 064h, _Poslati + 00001h

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00091	    poslati[2] = Temperature   
	MOVE?WB	_Temperature, _Poslati + 00002h

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00092	    serout2 tx ,396,[sign,dec2 poslati[1],",",dec2 poslati[2],10]
	SEROUT2DPIN?T	_TX
	SEROUT2MODE?C	0018Ch
	SEROUT2PACE?C	000h
	SEROUT2?B	_SIGN
	SEROUT2COUNT?C	002h
	SEROUT2NUM?B	_Poslati + 00001h
	SEROUT2DEC?	
	SEROUT2?C	02Ch
	SEROUT2COUNT?C	002h
	SEROUT2NUM?B	_Poslati + 00002h
	SEROUT2DEC?	
	SEROUT2?C	00Ah

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00093	NemaPodataka:

	LABEL?L	_NemaPodataka	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00094	@ INT_RETURN

	ASM?
 INT_RETURN

	ENDASM?


; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00096	IzmeriTemperaturu: 

	LABEL?L	_IzmeriTemperaturu	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00097	    OWOut DQ, 1, [$CC, $44 ]       	
	OWPIN?T	_DQ
	OWMODE?C	001h
	OWOUT?C	0CCh
	OWOUT?C	044h
	OWEND?	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00098	    WHILE NOT DQ
	LABEL?L	L00002	
	CMPT?TL	_DQ, L00003

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00099	    WEND
	GOTO?L	L00002
	LABEL?L	L00003	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00100	    OWOUT DQ, 1, [$CC, $BE ]                       													
	OWPIN?T	_DQ
	OWMODE?C	001h
	OWOUT?C	0CCh
	OWOUT?C	0BEh
	OWEND?	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00101	    OWIN  DQ, 2, [Temperature.Lowbyte, Temperature.Highbyte]
	OWPIN?T	_DQ
	OWMODE?C	002h
	OWIN?B	_Temperature??LOWBYTE
	OWIN?B	_Temperature??HIGHBYTE
	OWEND?	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00102	    IF Temperature.15 THEN
	CMPF?TL	_Temperature??15, L00004

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00103	        Temperature = ~Temperature + 1
	NOT?WW	_Temperature, T1
	ADD?WCW	T1, 001h, _Temperature

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00104	        Twist = 1
	MOVE?CB	001h, _Twist

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00105	    ENDIF
	LABEL?L	L00004	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00106	    TempC = (Temperature & $7FF)>>4   				
	AND?WCW	_Temperature, 007FFh, T1
	SHIFTR?WCW	T1, 004h, _TempC

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00107	    Float = ((Temperature.Lowbyte & $0F)*25)>>2    
	AND?BCW	_Temperature??LOWBYTE, 00Fh, T1
	MUL?WCW	T1, 019h, T1
	SHIFTR?WCW	T1, 002h, _Float

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00108	    Temperature = TempC*100 + Float						
	MUL?WCW	_TempC, 064h, T1
	ADD?WWW	T1, _Float, _Temperature

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00109	    IF Twist = 1 THEN
	CMPNE?BCL	_Twist, 001h, L00006

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00110	        V= 10000 - Temperature                
	SUB?CWW	02710h, _Temperature, _V

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00111	        Twist = 0 
	MOVE?CB	000h, _Twist

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00112	    else
	GOTO?L	L00007
	LABEL?L	L00006	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00113	        V= 10000 + Temperature
	ADD?CWW	02710h, _Temperature, _V

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00114	    EndIf
	LABEL?L	L00007	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00115	    If v = 10000 then                      
	CMPNE?WCL	_V, 02710h, L00008

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00116	        Sign = " " 				
	MOVE?CB	020h, _SIGN

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00117	    Else 
	GOTO?L	L00009
	LABEL?L	L00008	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00118	        If v < 10000 then              	
	CMPGE?WCL	_V, 02710h, L00010

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00119	            Sign="-"					
	MOVE?CB	02Dh, _SIGN

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00120	        Else
	GOTO?L	L00011
	LABEL?L	L00010	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00121	            Sign="+"				
	MOVE?CB	02Bh, _SIGN

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00122	        EndIf
	LABEL?L	L00011	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00123	    EndIf
	LABEL?L	L00009	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00124	    If V >= 10000 then                           
	CMPLT?WCL	_V, 02710h, L00012

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00125	        Temperature=V-10000                   
	SUB?WCW	_V, 02710h, _Temperature

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00126	    Else                                   
	GOTO?L	L00013
	LABEL?L	L00012	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00127	        Temperature=10000-V                 
	SUB?CWW	02710h, _V, _Temperature

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00128	    EndIf
	LABEL?L	L00013	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00129	return
	RETURN?	

; D:\DAMIR\PROJEKTI\TWEETTERMO\TWITTERTERM PBP\SA INTERUPT\TWITTERTERM_INTERUPT.PBP	00130	END
	END?	

	END
