from pydub import AudioSegment

from math import *
from scipy import signal
import scipy.io.wavfile as wavfile
import numpy as np
import pyaudio
import wave
import matplotlib.pyplot as plt
from scipy.signal import butter, lfilter
from scipy.signal import freqz
from fnmatch import fnmatch
import os
import random


## read wave file and return data and rate
def readSoundChanel(filename, chanel):
  fs, data = wavfile.read(filename)
  res = []

  if type(data[0]) is np.ndarray:
    for dat in data:
      res.append(float(dat[chanel]))
      # res.append(float(dat[chanel])/32767)
  else:
    res = float(data)

  print fs, len(data)
  return [fs, np.asarray(res, dtype=np.int)]


def freqTest(data, fs):
  # p=(np.abs(np.fft.rfft(data)))/(fs/2)
  # plt.plot(p)
  p = 20 * np.log10(np.abs(np.fft.rfft(data)))
  f = np.linspace(0, fs / 2, len(p))
  plt.plot(f, p, 'x')
  plt.show()


def freqTestSimple(data, fs):
  p = (np.abs(np.fft.rfft(data))) / (fs / 2)
  plt.plot(p)
  plt.show()

def gauss(x, *p):
	a, b, c, d = p
	y = a*np.exp(-np.power((x - b), 2.)/(2. * c**2.)) + d

	return y

def mp3toWav(source, destination):
  sound = AudioSegment.from_mp3(source)
  sound.export(destination, format="wav")


def plotMultiData( data):
    for dat in data:
        plt.plot(dat)
    plt.show()


def processWav(filename):
    [fs, bria] = readSoundChanel(filename, 0)
    bands = 32 * 2
    sinirBand = 30
    detayAraligi = 3
    kabaAralik = 7
    pencereBoyu = fs / 50

    pencereOteleme = pencereBoyu / 1
    pencereSayisi = len(bria) / pencereOteleme - 1;

    sonuc = np.zeros((pencereSayisi, bands), dtype=np.int16)


    #pencereSayisi = 100
    #pencereBoyu = fs / 50
    #pencereOteleme = fs / 100
    veriBaslama = 0


    #sonuc = np.zeros((pencereSayisi, bands), dtype=np.int16)

    # %%
    for pencere in range(pencereSayisi):
        data = bria[veriBaslama + pencere * pencereOteleme:veriBaslama + pencere * pencereOteleme + pencereBoyu]
        #data = data *
        pp = (np.abs(np.fft.rfft(data))) / (len(data) / 2)
        for band in range(bands):
            if (band < sinirBand):
                sonuc[pencere, band] = sum(1 + pp[band * detayAraligi:1 + (band + 1) * detayAraligi]) / 100
            else:
                sonuc[pencere, band] = sum(pp[detayAraligi * sinirBand + (band - sinirBand) * kabaAralik:detayAraligi * sinirBand + ( band - sinirBand + 1) * kabaAralik]) / 50

    zonuc = np.zeros((pencereSayisi, bands), dtype=np.int16)
    zonuc[sonuc[:, :] > 5] = 1
    zonuc[sonuc[:, :] > 10] = 2

    plt.imshow(np.transpose(zonuc))
    plt.show()



def tranformData():
    for i in range(1,6):
        source = "/Users/ser/Desktop/filme/Fundatia/Asimov Isaac - Fundatia - Cd"+ str(i)+".mp3"
        destination = "/Users/ser/OneDrive/teza/code/mac/fundatia"+str(i)+".wav"
        mp3toWav(source, destination)
i=5
source = "/Users/ser/Desktop/filme/Fundatia/Asimov Isaac - Fundatia - Cd" + str(i) + ".mp3"
destination = "/Users/ser/Desktop/filme/Fundatia/fundatia" + str(i) + ".wav"
#source ="/Users/ser/Desktop/filme/BILLBOARD TOP 100 [2002]/001. Nickelback - How You Remind Me.mp3"
#destination = "/Users/ser/Desktop/filme/BILLBOARD TOP 100 [2002]/001. Nickelback.wav"

destination = '/Users/ser/OneDrive/spectron/data/amy.wav'
processWav(destination)

