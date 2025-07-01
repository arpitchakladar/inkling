{
	description = "Flake for development environment for inkling.";

	inputs = {
		nixpkgs.url = "github:nixos/nixpkgs?ref=nixos-25.05";
	};

	outputs = { self, nixpkgs }:
	let
		pkgs = nixpkgs.legacyPackages."x86_64-linux";
	in {
		devShells."x86_64-linux".default = (pkgs.buildFHSEnv {
			name = "avalonia-dotnet-x11";
			targetPkgs = pkgs: (with pkgs; [
				dotnet-sdk_9
				udev
				alsa-lib
				fontconfig
				glew
			]) ++ (with pkgs.xorg; [
				# Avalonia UI
				libX11
				libICE
				libSM
				libXi
				libXcursor
				libXext
				libXrandr
			]);
			multiPkgs = pkgs: (with pkgs; [
				udev
				alsa-lib
			]);
			runScript = "zsh";
		}).env;
	};
}
