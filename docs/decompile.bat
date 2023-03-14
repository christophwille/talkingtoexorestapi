dotnet new tool-manifest
dotnet tool install --local ilspycmd --version 8.0.0.7246-preview3

dotnet ilspycmd --project --use-varnames-from-pdb --outputdir "src/RestApiClient" Microsoft.Exchange.Management.RestApiClient.dll
dotnet ilspycmd -p -usepdb -o "src/AdminApiProvider" Microsoft.Exchange.Management.AdminApiProvider.dll
dotnet ilspycmd -p -usepdb -o "src/ExoPowershellGalleryModule" Microsoft.Exchange.Management.ExoPowershellGalleryModule.dll