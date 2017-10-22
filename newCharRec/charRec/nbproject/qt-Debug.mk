#############################################################################
# Makefile for building: dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/charRec
# Generated by qmake (1.07a) (Qt 3.3.8) on: Wed Mar  1 19:17:44 2017
# Project:  nbproject/qt-Debug.pro
# Template: app
# Command: $(QMAKE) -spec macx-g++ "VPATH=." -o qttmp-Debug.mk nbproject/qt-Debug.pro
#############################################################################

####### Compiler, tools and options

CC       = gcc
CXX      = g++
LEX      = flex
YACC     = yacc
CFLAGS   = -pipe -Wall -W -g  
CXXFLAGS = -pipe -Wall -W -g  
LEXFLAGS = 
YACCFLAGS= -d
INCPATH  = -I/opt/local/lib/qt3/mkspecs/macx-g++ -Inbproject -I$(QTDIR)/include -I.
LINK     = c++
LFLAGS   = -headerpad_max_install_names -prebind
LIBS     = $(SUBLIBS) -L$(QTDIR)/lib -lqt
AR       = ar cq
RANLIB   = ranlib -s
MOC      = $(QTDIR)/bin/moc
UIC      = $(QTDIR)/bin/uic
QMAKE    = qmake
TAR      = tar -cf
GZIP     = gzip -9f
COPY     = cp -f
COPY_FILE= cp -f
COPY_DIR = cp -f -r
INSTALL_FILE= $(COPY_FILE)
INSTALL_DIR = $(COPY_DIR)
DEL_FILE = rm -f
SYMLINK  = ln -sf
DEL_DIR  = rmdir
MOVE     = mv -f
CHK_DIR_EXISTS= test -d
MKDIR    = mkdir -p

####### Output directory

OBJECTS_DIR = build/Debug/GNU-MacOSX/

####### Files

HEADERS = 
SOURCES = main.cpp
OBJECTS = build/Debug/GNU-MacOSX/main.o
FORMS = 
UICDECLS = 
UICIMPLS = 
SRCMOC   = 
OBJMOC = 
DIST	   = nbproject/qt-Debug.pro
QMAKE_TARGET = charRec
DESTDIR  = dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/
TARGET   = dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/charRec

first: all
####### Implicit rules

.SUFFIXES: .c .o .cpp .cc .cxx .C

.cpp.o:
	$(CXX) -c $(CXXFLAGS) $(INCPATH) -o $@ $<

.cc.o:
	$(CXX) -c $(CXXFLAGS) $(INCPATH) -o $@ $<

.cxx.o:
	$(CXX) -c $(CXXFLAGS) $(INCPATH) -o $@ $<

.C.o:
	$(CXX) -c $(CXXFLAGS) $(INCPATH) -o $@ $<

.c.o:
	$(CC) -c $(CFLAGS) $(INCPATH) -o $@ $<

####### Build rules

all: qttmp-Debug.mk dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/../PkgInfo dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/../Info.plist $(TARGET)

$(TARGET):  $(UICDECLS) $(OBJECTS) $(OBJMOC)  
	test -d dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/ || mkdir -p dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/
	$(LINK) $(LFLAGS) -o $(TARGET) $(OBJECTS) $(OBJMOC) $(OBJCOMP) $(LIBS)

mocables: $(SRCMOC)
uicables: $(UICDECLS) $(UICIMPLS)

$(MOC): 
	( cd $(QTDIR)/src/moc && $(MAKE) )

qttmp-Debug.mk: nbproject/qt-Debug.pro  /opt/local/lib/qt3/mkspecs/macx-g++/qmake.conf 
	$(QMAKE) -spec macx-g++ "VPATH=." -o qttmp-Debug.mk nbproject/qt-Debug.pro
qmake: 
	@$(QMAKE) -spec macx-g++ "VPATH=." -o qttmp-Debug.mk nbproject/qt-Debug.pro

dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/../PkgInfo: 
	@test -d dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/ || mkdir -p dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/
	@$(DEL_FILE) dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/../PkgInfo
	@echo "APPL????" >dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/../PkgInfo
dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/../Info.plist: 
	@test -d dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/ || mkdir -p dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/
	@$(DEL_FILE) dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/../Info.plist
	@sed -e "s,@ICON@,application.icns,g" -e "s,@EXECUTABLE@,charRec,g" "/opt/local/lib/qt3/mkspecs/macx-g++/Info.plist.app" >"dist/Debug/GNU-MacOSX/charRec.app/Contents/MacOS/../Info.plist"
dist: 
	@mkdir -p nbproject/build/Debug/GNU-MacOSX/charRec && $(COPY_FILE) --parents $(SOURCES) $(HEADERS) $(FORMS) $(DIST) nbproject/build/Debug/GNU-MacOSX/charRec/ && ( cd `dirname nbproject/build/Debug/GNU-MacOSX/charRec` && $(TAR) charRec.tar charRec && $(GZIP) charRec.tar ) && $(MOVE) `dirname nbproject/build/Debug/GNU-MacOSX/charRec`/charRec.tar.gz . && $(DEL_FILE) -r nbproject/build/Debug/GNU-MacOSX/charRec

mocclean:

uiclean:

yaccclean:
lexclean:
clean:
	-$(DEL_FILE) $(OBJECTS)
	-$(DEL_FILE) *~ core *.core


####### Sub-libraries

distclean: clean
	-$(DEL_FILE) -r dist/Debug/GNU-MacOSX/charRec.app


FORCE:

####### Compile

build/Debug/GNU-MacOSX/main.o: main.cpp 
	$(CXX) -c $(CXXFLAGS) $(INCPATH) -o build/Debug/GNU-MacOSX/main.o main.cpp

####### Install

install:  

uninstall:  
