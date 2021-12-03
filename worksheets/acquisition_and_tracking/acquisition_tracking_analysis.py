from pathlib import Path
import numpy as np

raw_audio_file = Path(
    'D://Google_Drive_0//learning//cs//languages//textbooks_and_courses//bonsai'
    '//swc_en_2021//worksheets//acquisition_and_tracking'
    '//acquisition_and_tracking._raw.bin')
raw_audio = np.fromfile(raw_audio_file, dtype=np.int16)
