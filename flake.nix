{
	description = "Flake for development environment for inkling.";

	inputs = {
		nixpkgs.url = "github:nixos/nixpkgs?ref=nixos-25.05";
		flake-utils.url = "github:numtide/flake-utils";
	};

	outputs = { self, nixpkgs, flake-utils }:
		flake-utils.lib.eachDefaultSystem (system:
			let
				pkgs = import nixpkgs { inherit system; };
			in {
				devShells.default = (pkgs.buildFHSEnv {
					name = "inkling-avalonia-dotnet";
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
			}
		);
}
