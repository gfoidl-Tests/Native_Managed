#!/bin/bash

config=${1:-Debug}

echo "Building with config $config"
export BUILD_CONFIG=$config

binPath="bin/$config"
mkdir -p $binPath
cd $_

configFlags="-DCMAKE_BUILD_TYPE=$config"

# alternatively
#$ export CC=clang
#$ export CXX=clang++
if [[ "$2" == "clang" ]]; then
	configFlags="$configFlags -DCMAKE_C_COMPILER=clang-3.8 -DCMAKE_CXX_COMPILER=clang++-3.8"
fi

cmake $configFlags ../..
cmake --build . --config $config

echo ""
echo "output written to $binPath"
