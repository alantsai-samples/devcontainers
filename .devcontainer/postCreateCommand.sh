#!/bin/bash

# Install Python packages
pip install requests beautifulsoup4 pandas scrapy

# Add Microsoft package signing key
curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.gpg
sudo mv microsoft.gpg /etc/apt/trusted.gpg.d/microsoft.gpg

# Add Microsoft APT repository for Azure Functions Core Tools
sudo sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/debian/$(lsb_release -rs | cut -d"." -f1)/prod $(lsb_release -cs) main" > /etc/apt/sources.list.d/dotnetdev.list'

# Update and install Azure Functions Core Tools
sudo apt-get update
sudo apt-get install -y azure-functions-core-tools-4