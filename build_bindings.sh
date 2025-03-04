#!/bin/bash

# This script is used to build the source generated bindings for FishyFlip
# It includes a list of git repos to be cloned, building FFSourceGen, and passing the directories into it
# to generate the bindings

# List of git repos to clone
REPOS=(
    "https://github.com/bluesky-social/atproto.git"
)

PWD=$(pwd)

# Clone the repos
for REPO in "${REPOS[@]}"
do
    user_repo=$(echo "$REPO" | grep -o '[^/]*/[^/]*\.git$' | sed 's/\.git$//')
    username=$(echo "$user_repo" | cut -d'/' -f1)
    repo_name=$(echo "$user_repo" | cut -d'/' -f2)
    target_dir="${username}-${repo_name}"
    if [ -d "../fflexicons/$target_dir" ]; then
        echo "Updating $target_dir"
        cd "../fflexicons/$target_dir"
        git pull
        cd -
    else
        echo "Cloning $target_dir"
        git clone "$REPO" "../fflexicons/$target_dir"
    fi
done

# Create list of cloned repo directories from the above list except for atproto
    
REPO_DIRS=()
for REPO in "${REPOS[@]}"
do
    user_repo=$(echo "$REPO" | grep -o '[^/]*/[^/]*\.git$' | sed 's/\.git$//')
    username=$(echo "$user_repo" | cut -d'/' -f1)
    repo_name=$(echo "$user_repo" | cut -d'/' -f2)
    target_dir="${username}-${repo_name}"
    if [ "$target_dir" != "bluesky-social-atproto" ]; then
        if [ "$target_dir" == "whtwnd-whitewind-blog" ]; then
            REPO_DIRS+=("$PWD/../fflexicons/$target_dir/lexicons/com/whtwnd")
        elif [ "$target_dir" == "ziodotsh-lexicons" ]; then
            REPO_DIRS+=("$PWD/../fflexicons/$target_dir/blue/zio")
        elif [ "$target_dir" == "shinolabs-PinkSea" ]; then
            REPO_DIRS+=("$PWD/../fflexicons/$target_dir/PinkSea.Lexicons/com")
        elif [ "$target_dir" == "likeandscribe-frontpage" ]; then
            REPO_DIRS+=("$PWD/../fflexicons/$target_dir/lexicons/fyi")
        elif [ "$target_dir" == "Gregoor-skylights" ]; then
            REPO_DIRS+=("$PWD/../fflexicons/$target_dir/web/lexicons")
        elif [ "$target_dir" == "lexicon-community-lexicon" ]; then
            REPO_DIRS+=("$PWD/../fflexicons/$target_dir/community/lexicon")
        elif [ "$target_dir" == "teal-fm-teal" ]; then
            REPO_DIRS+=("$PWD/../fflexicons/$target_dir/packages/lexicons/real")
        elif [ "$target_dir" == "icidasset-radical-edward" ]; then
            REPO_DIRS+=("$PWD/../fflexicons/$target_dir/apps/byov/lexicons/ma/tokono/byov")
        else
            REPO_DIRS+=("$PWD/../fflexicons/$target_dir/lexicons")
        fi
    fi
done
    
# Build FFSourceGen
dotnet build tools/FFSourceGen/FFSourceGen.csproj
dotnet run --project tools/FFSourceGen/FFSourceGen.csproj -- generate $PWD/../fflexicons/bluesky-social-atproto/lexicons -o $PWD/src/FishyFlip/ -t "${REPO_DIRS[@]}"

# Build FishyFlip to verify the bindings compile

dotnet build src/FishyFlip/FishyFlip.csproj -c Release