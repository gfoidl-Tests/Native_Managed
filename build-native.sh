#!/bin/bash

config=${1:-Debug}

echo "Building with config $config"
export BUILD_CONFIG=$config

binPath="bin/$config"
mkdir -p $binPath
cd $_

cmake -DCMAKE_BUILD_TYPE=$config ../..
cmake --build . --config $config

echo ""
echo "output written to $binPath"
