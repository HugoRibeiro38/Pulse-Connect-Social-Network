import SidebarItem from '@/components/Sidebar/SidebarItem';
import { type NavigationItemProps, navigationItems } from '@/data/navigation';

const Sidebar: React.FunctionComponent = (): React.ReactNode => {
	return (
		<aside className='w-min border-r border-input p-8'>
			<nav className='h-full w-full'>
				<ul className='flex h-full w-full flex-col items-center justify-between'>
					{Object.keys(navigationItems).map(
						(categoty: string, index: number) => (
							<li
								key={`${categoty}-${index}`}
								className='flex w-full flex-col items-center justify-between gap-y-8'>
								{navigationItems[categoty]?.map(
									(
										item: NavigationItemProps,
										index: number,
									) => (
										<SidebarItem
											key={`${item.title}-${index}`}
											href={item.href}
											title={item.title}
											icon={item.icon}
										/>
									),
								)}
							</li>
						),
					)}
				</ul>
			</nav>
		</aside>
	);
};

export default Sidebar;
